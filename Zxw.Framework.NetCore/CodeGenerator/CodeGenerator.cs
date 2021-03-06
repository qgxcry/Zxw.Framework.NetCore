﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AspectCore.Extensions.Reflection;
using Microsoft.Extensions.Options;
using NpgsqlTypes;
using Zxw.Framework.NetCore.DbContextCore;
using Zxw.Framework.NetCore.Extensions;
using Zxw.Framework.NetCore.IoC;
using Zxw.Framework.NetCore.Options;
using Zxw.Framework.NetCore.Models;

namespace Zxw.Framework.NetCore.CodeGenerator
{
    /// <summary>
    /// 代码生成器。
    /// <remarks>
    /// 根据指定的实体域名空间生成Repositories和Services层的基础代码文件。
    /// </remarks>
    /// </summary>
    public class CodeGenerator
    {
        private static readonly string Delimiter = "\\";//分隔符，默认为windows下的\\分隔符

        private static IOptions<CodeGenerateOption> options =
            AspectCoreContainer.Resolve<IOptions<CodeGenerateOption>>();

        /// <summary>
        /// 静态构造函数：从IoC容器读取配置参数，如果读取失败则会抛出ArgumentNullException异常
        /// </summary>
        static CodeGenerator()
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var flag = path.IndexOf("/bin");
            if (flag > 0)
                Delimiter = "/";//如果可以取到值，修改分割符
        }

        /// <summary>
        /// 生成指定的实体域名空间下各实体对应Repositories和Services层的基础代码文件
        /// </summary>
        /// <param name="ifExsitedCovered">如果目标文件存在，是否覆盖。默认为false</param>
        public static void Generate(bool ifExsitedCovered = false)
        {
            var assembly = Assembly.Load(options.Value.ModelsNamespace);
            var types = assembly?.GetTypes();
            var list = types?.Where(t =>
                t.IsClass && !t.IsGenericType && !t.IsAbstract && !t.IsNested);
            if (list != null)
            {
                foreach (var type in list)
                {
                    var baseType = typeof(BaseModel<>).MakeGenericType(new[] { type.BaseType?.GenericTypeArguments[0] });
                    if (type.IsSubclassOf(baseType))
                    {
                        GenerateSingle(type, ifExsitedCovered);
                    }
                }
            }
        }

        /// <summary>
        /// 生成指定的实体对应IServices和Services层的基础代码文件
        /// </summary>
        /// <typeparam name="T">实体类型（必须实现IBaseModel接口）</typeparam>
        /// <typeparam name="TKey">实体主键类型</typeparam>
        /// <param name="ifExsitedCovered">如果目标文件存在，是否覆盖。默认为false</param>
        public static void GenerateSingle<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            GenerateSingle(typeof(T), ifExsitedCovered);
        }

        /// <summary>
        /// 生成指定的实体对应IServices和Services层的基础代码文件
        /// </summary>
        /// <param name="modelType">实体类型（必须实现IBaseModel接口）</param>
        /// <param name="ifExsitedCovered">如果目标文件存在，是否覆盖。默认为false</param>
        private static void GenerateSingle(Type modelType, bool ifExsitedCovered = false)
        {
            var modelTypeName = modelType.Name;
            var keyTypeName = modelType.GetProperty("Id")?.PropertyType.Name;
            GenerateIRepository(modelTypeName, keyTypeName, ifExsitedCovered);
            GenerateRepository(modelTypeName, keyTypeName, ifExsitedCovered);
            GenerateController(modelTypeName, keyTypeName, ifExsitedCovered);
        }

        /// <summary>
        /// 从代码模板中读取内容
        /// </summary>
        /// <param name="templateName">模板名称，应包括文件扩展名称。比如：template.txt</param>
        /// <returns></returns>
        private static string ReadTemplate(string templateName)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var content = string.Empty;
            using (var stream = currentAssembly.GetManifestResourceStream($"{currentAssembly.GetName().Name}.CodeTemplate.{templateName}"))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        content = reader.ReadToEnd();
                    }
                }
            }
            return content;
        }

        /// <summary>
        /// 生成IRepository层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateIRepository(string modelTypeName, string keyTypeName, bool ifExsitedCovered = false)
        {
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "IRepositories";
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + "I" + modelTypeName + "Repository.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("IRepositoryTemplate.txt");
            content = content.Replace("{ModelsNamespace}", options.Value.ModelsNamespace)
                .Replace("{IRepositoriesNamespace}", options.Value.IRepositoriesNamespace)
                .Replace("{ModelTypeName}", modelTypeName)
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成IService层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateIService(DbTable table, string keyTypeName, bool ifExsitedCovered = false)
        {
            var modelTypeName = table.TableName;
            var groupName = table.TableComment.Extract(@"\[(.*)\]");
            var keyColumnName = table.Columns.First(m => m.IsPrimaryKey).ColName;
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "ZLHP." + groupName + ".Contract\\Services";
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + "I" + modelTypeName + "Service.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyTemplate.IServiceTemplate.txt");
            content = content.Replace("{GroupName}", groupName)
                .Replace("{ModelName}", modelTypeName)
                .Replace("{keyColumnName}", keyColumnName)
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成Service层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateService(DbTable table, string keyTypeName, bool ifExsitedCovered = false)
        {
            var modelTypeName = table.TableName;
            var groupName = table.TableComment.Extract(@"\[(.*)\]");
            var keyColumnName = table.Columns.First(m => m.IsPrimaryKey).ColName;
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "ZLHP." + groupName + ".Services\\Services";
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + modelTypeName + "Service.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyTemplate.ServiceTemplate.txt");
            content = content.Replace("{GroupName}", groupName)
                .Replace("{ModelName}", modelTypeName)
                .Replace("{keyColumnName}", keyColumnName)
                .Replace("{modelName}", modelTypeName.FirstCharToLower())
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成BaseService层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateBaseService(string groupName, string keyTypeName, bool ifExsitedCovered = false)
        {
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "ZLHP." + groupName + ".Services\\Services";
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + groupName + "BaseService.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyTemplate.BaseServiceTemplate.txt");
            content = content.Replace("{GroupName}", groupName)
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成IBaseService层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateIBaseService(string groupName, string keyTypeName, bool ifExsitedCovered = false)
        {
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "ZLHP." + groupName + ".Contract\\Services";
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + "I" + groupName + "BaseService.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyTemplate.IBaseServiceTemplate.txt");
            content = content.Replace("{GroupName}", groupName)

                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成IGrain层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateIGrain(DbTable table, string keyTypeName, bool ifExsitedCovered = false)
        {
            var modelTypeName = table.TableName;
            var groupName = table.TableComment.Extract(@"\[(.*)\]");
            var keyColumnName = table.Columns.First(m => m.IsPrimaryKey).ColName;
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "ZLHP." + groupName + ".Contract\\Facades";
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + "I" + modelTypeName + "Grain.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyTemplate.IGrainTemplate.txt");
            content = content.Replace("{GroupName}", groupName)
                .Replace("{ModelName}", modelTypeName)
                .Replace("{keyColumnName}", keyColumnName)
                .Replace("{modelName}", modelTypeName.FirstCharToLower())
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成Grain层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateGrain(DbTable table, string keyTypeName, bool ifExsitedCovered = false)
        {
            var modelTypeName = table.TableName;
            var groupName = table.TableComment.Extract(@"\[(.*)\]");
            var keyColumnName = table.Columns.First(m => m.IsPrimaryKey).ColName;
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "ZLHP." + groupName + ".Grains";
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + modelTypeName + "Grain.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyTemplate.GrainTemplate.txt");
            content = content.Replace("{GroupName}", groupName)
                .Replace("{ModelName}", modelTypeName)
                .Replace("{keyColumnName}", keyColumnName)
                .Replace("{modelName}", modelTypeName.FirstCharToLower())
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成Grain层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateController(DbTable table, string keyTypeName, bool ifExsitedCovered = false)
        {
            var modelTypeName = table.TableName;
            var groupName = table.TableComment.Extract(@"\[(.*)\]");
            var keyColumnName = table.Columns.First(m => m.IsPrimaryKey).ColName;
            var iRepositoryPath = options.Value.OutputPath + Delimiter + "ZLHP.Web\\Controllers\\Owners\\" + groupName;
            if (!Directory.Exists(iRepositoryPath))
            {
                Directory.CreateDirectory(iRepositoryPath);
            }
            var fullPath = iRepositoryPath + Delimiter + modelTypeName + "Controller.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("MyTemplate.ControllerTemplate.txt");
            content = content.Replace("{GroupName}", groupName)
                .Replace("{ModelName}", modelTypeName)
                .Replace("{keyColumnName}", keyColumnName)
                .Replace("{modelName}", modelTypeName.FirstCharToLower())
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成Repository层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateRepository(string modelTypeName, string keyTypeName, bool ifExsitedCovered = false)
        {
            var repositoryPath = options.Value.OutputPath + Delimiter + "Repositories";
            if (!Directory.Exists(repositoryPath))
            {
                Directory.CreateDirectory(repositoryPath);
            }
            var fullPath = repositoryPath + Delimiter + modelTypeName + "Repository.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("RepositoryTemplate.txt");
            content = content.Replace("{ModelsNamespace}", options.Value.ModelsNamespace)
                .Replace("{IRepositoriesNamespace}", options.Value.IRepositoriesNamespace)
                .Replace("{RepositoriesNamespace}", options.Value.RepositoriesNamespace)
                .Replace("{ModelTypeName}", modelTypeName)
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 生成Controller层代码文件
        /// </summary>
        /// <param name="modelTypeName"></param>
        /// <param name="keyTypeName"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateController(string modelTypeName, string keyTypeName, bool ifExsitedCovered = false)
        {
            var controllerPath = options.Value.OutputPath + Delimiter;
            if (!Directory.Exists(controllerPath))
            {
                Directory.CreateDirectory(controllerPath);
            }
            var fullPath = controllerPath + Delimiter + modelTypeName + "Controller.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;
            var content = ReadTemplate("ControllerTemplate.txt");
            content = content.Replace("{ModelsNamespace}", options.Value.ModelsNamespace)
                .Replace("{IRepositoriesNamespace}", options.Value.IRepositoriesNamespace)
                .Replace("{ControllersNamespace}", options.Value.ControllersNamespace)
                .Replace("{ModelTypeName}", modelTypeName)
                .Replace("{KeyTypeName}", keyTypeName);
            WriteAndSave(fullPath, content);
        }

        /// <summary>
        /// 根据数据表生成Model层、Controller层、IRepository层和Repository层代码
        /// </summary>
        /// <param name="ifExsitedCovered">是否覆盖已存在的同名文件</param>
        public static void GenerateAllCodesFromDatabase(bool ifExsitedCovered = false, bool coveredSGC = false)
        {
            var dbContext = AspectCoreContainer.Resolve<IDbContextCore>();
            if (dbContext == null)
                throw new Exception("未能获取到数据库上下文，请先注册数据库上下文。");

            #region 获取Comment枚举 格式用[枚举代码，枚举值]包裹枚举值,每行代表一个枚举类型

            var columnEnums = dbContext.GetAllEnumComments();
            var listEnums = new Dictionary<string, string>();
            foreach (var col in columnEnums)
            {
                GenerateEnum(col, listEnums, ifExsitedCovered);
            }

            #endregion 获取Comment枚举 格式用[枚举代码，枚举值]包裹枚举值,每行代表一个枚举类型

            var tables = dbContext.GetCurrentDatabaseTableList();
            if (tables != null && tables.Any())
            {
                foreach (var table in tables)
                {
                    if (table.Columns.Any(c => c.IsPrimaryKey))
                    {
                        var groupName = options.Value.GroupName;
                        var tableNames = options.Value.Tables;
                        var currGroupName = table.TableComment.Extract(@"\[(.*)\]");
                        currGroupName = string.IsNullOrEmpty(groupName) ? "Default" : currGroupName;
                        if (string.IsNullOrEmpty(groupName) || currGroupName == groupName)
                        {
                            if (tableNames == null || tableNames.Contains(table.TableName))
                            {
                                var pkTypeName = table.Columns.First(m => m.IsPrimaryKey).CSharpType;
                                GenerateEntity(table, listEnums, ifExsitedCovered: ifExsitedCovered);
                                GenerateEntity(table, listEnums, ModelType.Dto, ifExsitedCovered: ifExsitedCovered);
                                //GenerateEntity(table, listEnums, ModelType.JsonModel, ifExsitedCovered: ifExsitedCovered);
                                GenerateEntity(table, listEnums, ModelType.ViewModel, ifExsitedCovered: ifExsitedCovered);
                                GenerateIBaseService(currGroupName, pkTypeName, coveredSGC);
                                GenerateBaseService(currGroupName, pkTypeName, coveredSGC);
                                GenerateIService(table, pkTypeName, coveredSGC);
                                GenerateService(table, pkTypeName, coveredSGC);
                                GenerateIGrain(table, pkTypeName, coveredSGC);
                                GenerateGrain(table, pkTypeName, coveredSGC);
                                GenerateController(table, pkTypeName, coveredSGC);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="column"></param>
        /// <param name="dic"></param>
        /// <param name="ifExsitedCovered"></param>
        private static void GenerateEnum(DbTableColumn column, Dictionary<string, string> dic, bool ifExsitedCovered = false)
        {
            //var currentAssembly = Assembly.GetExecutingAssembly();
            //var path = Path.GetDirectoryName(currentAssembly.Location);
            //var index = path.IndexOf("/bin");
            //index = index <= 0 ? path.IndexOf("\\bin") : index;
            //path = path.Substring(0, index);
            var path = options.Value.OutputPath + Delimiter;
            var modelPath = path + Delimiter + "ZLHP.Enums";
            if (!Directory.Exists(modelPath))
            {
                Directory.CreateDirectory(modelPath);
            }
            //if (dic.ContainsKey(column.ColName))
            //{
            //    column.ColName = column.ColName + "1";
            //}
            var fullPath = modelPath + Delimiter + column.ColName + "Enum.cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;

            var sb = new StringBuilder();
            var comment = column.Comment.Extract(@"\[(.*)\]");
            var lstEnumPro = comment.Replace("\r\n", "|").Split('|');
            foreach (var enumPro in lstEnumPro)
            {
                var tmp = GenerateEnumProperty(enumPro);
                sb.AppendLine(tmp);
            }

            var content = ReadTemplate("EnumTemplate.txt");
            content = content.Replace("{EnumNamespace}", options.Value.EnumsNamespace)
                .Replace("{ValType}", column.CSharpType == "string" ? "byte" : column.CSharpType)
                .Replace("{Comment}", column.Comment.Replace("\r\n", "\r\n\t/// "))
                .Replace("{EnumName}", column.ColName + "Enum")
                .Replace("{EnumProperties}", sb.ToString());
            WriteAndSave(fullPath, content);
            if (!dic.ContainsKey(column.ColName))
            {
                dic.Add(column.ColName, comment);
            }
        }

        private static string GenerateEnumProperty(string item)
        {
            var sb = new StringBuilder();
            var pKeyVal = item.Split(new char[] { ',', ':', '，', '：' });
            if (pKeyVal.Count() >= 2)
            {
                var key = pKeyVal[1].ClearNewLine().ClearSpecial();
                var val = pKeyVal[0].ClearNewLine().ClearSpecial();
                sb.AppendLine("\t\t/// <summary>");
                sb.AppendLine($"\t\t/// 名称：{key}，值：{val}");
                sb.AppendLine("\t\t/// </summary>");
                sb.AppendLine($"\t\t[DisplayName(\"{pKeyVal[1].ClearNewLine()}\")]");

                sb.AppendLine($"\t\t{key} = {val},");
            }
            return sb.ToString();
        }

        private static void GenerateEntity(DbTable table, Dictionary<string, string> dic, ModelType modelType = ModelType.Model, bool ifExsitedCovered = false)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var path = options.Value.OutputPath + Delimiter;
            var groupName = table.TableComment.Extract(@"\[(.*)\]");
            switch (modelType)
            {
                case ModelType.Model:
                    path = path + "ZLHP.Models" + Delimiter + groupName + "s";
                    break;

                case ModelType.Dto:
                    path = path + "ZLHP." + groupName + ".Contract\\Dtos";
                    break;

                case ModelType.ViewModel:
                    path = path + "ZLHP.Web\\Models\\Owners\\" + groupName + "s"; break;
            }
            var modelPath = path;
            if (!Directory.Exists(modelPath))
            {
                Directory.CreateDirectory(modelPath);
            }
            var ext = modelType != ModelType.Model ? modelType.ToString() : "";
            var fullPath = modelPath + Delimiter + table.TableName + ext + ".cs";
            if (File.Exists(fullPath) && !ifExsitedCovered)
                return;

            var pkTypeName = table.Columns.First(m => m.IsPrimaryKey).CSharpType;
            var keyColumnName = table.Columns.First(m => m.IsPrimaryKey).ColName;
            var sb = new StringBuilder();
            foreach (var column in table.Columns)
            {
                var tmp = GenerateEntityProperty(table.TableName, dic, column, modelType);
                sb.AppendLine(tmp);
                sb.AppendLine();
            }
            foreach (var tab in table.RefTables)
            {
                var tmp = GenerateRefTableProperty(table.TableName, tab, modelType);
                sb.AppendLine(tmp);
                sb.AppendLine();
            }
            var content = ReadTemplate($"{modelType.ToString()}Template.txt");
            var modelNamespace = "";
            switch (modelType)
            {
                case ModelType.Model: modelNamespace = "ZLHP." + groupName + ".Models"; break;
                case ModelType.Dto: modelNamespace = "ZLHP." + groupName + ".Contract.Dtos"; break;
                case ModelType.JsonModel: modelNamespace = options.Value.JsonModelsNamespace; break;
                case ModelType.ViewModel: modelNamespace = "ZLHP.Web.Models.Owners." + groupName + "s"; break;
                default: modelNamespace = options.Value.ModelsNamespace; break;
            }
            content = content.Replace("{ModelsNamespace}", modelNamespace)
                .Replace("{Comment}", table.TableComment)
                .Replace("{ModelName}", table.TableName)
                .Replace("{keyColumnName}", keyColumnName)
                .Replace("{KeyTypeName}", pkTypeName)
                .Replace("{ModelProperties}", sb.ToString());
            WriteAndSave(fullPath, content);
        }

        private static string GenerateRefTableProperty(string tableName, DbTable table, ModelType modelType = ModelType.Model)
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrEmpty(table.TableComment))
            {
                table.TableComment = table.TableComment.Replace("\r\n", "\r\n\t\t/// ");
                sb.AppendLine("\t\t/// <summary>");
                sb.AppendLine("\t\t/// " + table.TableComment);
                sb.AppendLine("\t\t/// </summary>");
            }
            var ext = modelType != ModelType.Model ? modelType.ToString() : "";
            sb.AppendLine($"\t\tpublic virtual ICollection<{table.TableName}{ext}> {table.TableName} " + "{get;set;}");
            return sb.ToString();
        }

        private static string GenerateEntityProperty(string tableName, Dictionary<string, string> dic, DbTableColumn column, ModelType modelType = ModelType.Model)
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrEmpty(column.Comment))
            {
                SetSummary(column.Comment, sb);
            }
            switch (modelType)
            {
                case ModelType.Model:
                    if (column.IsPrimaryKey)
                    {
                        SetKeyProperty(column, sb);
                    }
                    else
                    {
                        SetValidate(column, sb);
                        SetProperty(dic, column, sb);
                    }
                    break;

                case ModelType.Dto:
                    if (column.IsPrimaryKey)
                    {
                        column.IsNullable = true;
                    }
                    SetProperty(dic, column, sb);
                    break;

                case ModelType.JsonModel:
                    SetJsonProperty(column.Comment.Extract(@"【(.*)】"), sb);
                    if (column.IsPrimaryKey)
                    {
                        column.IsNullable = true;
                    }
                    SetProperty(dic, column, sb);
                    break;

                case ModelType.ViewModel:
                    SetValidate(column, sb);
                    if (column.IsPrimaryKey)
                    {
                        column.IsNullable = true;
                    }
                    SetProperty(dic, column, sb);
                    break;

                default:
                    break;
            }

            if (!String.IsNullOrEmpty(column.RefTableName))
            {
                SetForeignProperty(column, sb, modelType);
            }
            return sb.ToString();
        }

        private static void SetSummary(string val, StringBuilder sb)
        {
            sb.AppendLine("\t\t/// <summary>");
            sb.AppendLine("\t\t/// " + val.Replace("\r\n", "\r\n\t\t/// "));
            sb.AppendLine("\t\t/// </summary>");
        }

        private static void SetKeyProperty(DbTableColumn column, StringBuilder sb)
        {
            sb.AppendLine("\t\t[Key]");
            //sb.AppendLine($"\t\t[Column(\"{tableName}Id\")]");
            if (column.IsIdentity)
            {
                sb.AppendLine("\t\t[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
            }
            sb.AppendLine($"\t\tpublic  {column.CSharpType} {column.ColName} " + "{get;set;}");
        }

        private static void SetForeignProperty(DbTableColumn column, StringBuilder sb, ModelType modelType = ModelType.Model)
        {
            SetSummary(column.Comment, sb);
            if (modelType == ModelType.Model)
                sb.AppendLine($"\t\t[ForeignKey(\"{column.ColName}\")]");

            var ext = modelType != ModelType.Model ? modelType.ToString() : "";
            sb.AppendLine($"\t\tpublic virtual {column.RefTableName}{ext} {column.RefTableName} " + "{get;set;}");
        }

        private static void SetJsonProperty(string val, StringBuilder sb)
        {
            sb.AppendLine($"\t\t[JsonProperty(\"{val}\")]");
        }

        private static void SetValidate(DbTableColumn column, StringBuilder sb)
        {
            if (!column.IsNullable)
            {
                sb.AppendLine("\t\t[Required]");
            }

            if (column.ColumnLength.HasValue && column.ColumnLength.Value > 0)
            {
                sb.AppendLine($"\t\t[MaxLength({column.ColumnLength.Value})]");
            }
        }

        private static void SetProperty(Dictionary<string, string> dic, DbTableColumn column, StringBuilder sb)
        {
            var colType = column.CSharpType;
            if (colType.ToLower() != "string" && colType.ToLower() != "byte[]" && colType.ToLower() != "object" &&
                column.IsNullable)
            {
                colType = colType + "?";
            }
            if (colType.ToLower() != "string" && dic.ContainsKey(column.ColName) && dic.ContainsValue(column.Comment.Extract(@"\[(.*)\]")))
            {
                sb.AppendLine($"\t\tpublic {column.ColName}Enum? {column.ColName} " + "{get;set;}");
            }
            else
            {
                sb.AppendLine($"\t\tpublic {colType} {column.ColName} " + "{get;set;}");
            }
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="content"></param>
        private static void WriteAndSave(string fileName, string content)
        {
            //实例化一个文件流--->与写入文件相关联
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                //实例化一个StreamWriter-->与fs相关联
                using (var sw = new StreamWriter(fs))
                {
                    //开始写入
                    sw.Write(content);
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                }
            }
        }
    }
}