namespace Zxw.Framework.NetCore.Options
{
    public class CodeGenerateOption
    {
        public string OutputPath { get; set; }
        public string EnumsNamespace { get; set; }
        public string ModelsNamespace { get; set; }
        public string DtosNamespace { get; set; }
        public string JsonModelsNamespace { get; set; }
        public string ViewModelsNamespace { get; set; }
        public string ControllersNamespace { get; set; }
        public string IRepositoriesNamespace { get; set; }
        public string RepositoriesNamespace { get; set; }
    }
}