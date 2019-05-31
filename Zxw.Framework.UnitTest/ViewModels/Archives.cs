using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【产检档案】
	/// </summary>
	public class ArchivesViewModel
	{
		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		[Required]
		public long ArchiveID {get;set;}


		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		public long? PersonArchiveID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【孕妇编号】
		/// </summary>
		[MaxLength(50)]
		public string UserNo {get;set;}


		/// <summary>
		/// 【产检档案编号】
		/// </summary>
		[MaxLength(50)]
		public string ArchiveNo {get;set;}


		/// <summary>
		/// 【孕妇姓名】
		/// </summary>
		[MaxLength(50)]
		public string Name {get;set;}


		/// <summary>
		/// 【证件类型】[1，身份证
		///             2，军官证
		///             4，护照]
		/// </summary>
		public IdTypeEnum IdType {get;set;}


		/// <summary>
		/// 【身份证号】
		/// </summary>
		[MaxLength(50)]
		public string IDNumber {get;set;}


		/// <summary>
		/// 【预产期】
		/// </summary>
		public DateTime? DueDate {get;set;}


		/// <summary>
		/// 【末次月经日期】
		/// </summary>
		public DateTime? LastMenstrualDate {get;set;}


		/// <summary>
		/// 【月经周期】
		/// </summary>
		public int? MenstrualCycle {get;set;}


		/// <summary>
		/// 【经期】
		/// </summary>
		public int? MenstrualPeriod {get;set;}


		/// <summary>
		/// 【当前孕期】0，否
		///             1，是
		/// </summary>
		public byte? IsCurrent {get;set;}


		/// <summary>
		/// 【年龄】
		/// </summary>
		public int? Age {get;set;}


		/// <summary>
		/// 【结婚年龄】
		/// </summary>
		public int? MarriageAge {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		[MaxLength(50)]
		public string Phone {get;set;}


		/// <summary>
		/// 【文化程度】[0，研究生
		///             2，博士后
		///             3，博士
		///             4，硕士
		///             10，本科
		///             20，专科
		///             30，中专
		///             50，高中
		///             60，初中
		///             70，小学
		///             ]
		/// </summary>
		public EducationalEnum Educational {get;set;}


		/// <summary>
		/// 【职业】[0，国家机关、党群组织、企业、事业单位负责人
		///             1，专业技术人员 
		///             2，办事人员和有关人员
		///             3，商业、服务业人员
		///             4，农、林、牧、渔、水利业生产人员
		///             5，生产、运输设备操作人员及有关人员
		///             6，军人
		///             7，不便分类的其他从业人员
		///             8，无职业
		///             ]
		///             
		/// </summary>
		public ProfessionEnum Profession {get;set;}


		/// <summary>
		/// 【工作单位】
		/// </summary>
		[MaxLength(50)]
		public string Employer {get;set;}


		/// <summary>
		/// 【是否愿意自然分娩】1，自然分娩
		///             0，不愿意自然分娩
		/// </summary>
		public byte? IsNatural {get;set;}


		/// <summary>
		/// 【现住省份】
		/// </summary>
		[MaxLength(50)]
		public string Province {get;set;}


		/// <summary>
		/// 【现住城市】
		/// </summary>
		[MaxLength(50)]
		public string City {get;set;}


		/// <summary>
		/// 【现住区县】
		/// </summary>
		[MaxLength(50)]
		public string District {get;set;}


		/// <summary>
		/// 【现住地址】
		/// </summary>
		[MaxLength(50)]
		public string CurrAddress {get;set;}


		/// <summary>
		/// 【户口省份】
		/// </summary>
		[MaxLength(50)]
		public string RegProvince {get;set;}


		/// <summary>
		/// 【户口城市】
		/// </summary>
		[MaxLength(50)]
		public string RegCity {get;set;}


		/// <summary>
		/// 【户口区县】
		/// </summary>
		[MaxLength(50)]
		public string RegDistrict {get;set;}


		/// <summary>
		/// 【户口地址】
		/// </summary>
		[MaxLength(50)]
		public string RegAddress {get;set;}


		/// <summary>
		/// 【婚姻状况】[1，未婚
		///             2，已婚
		///             3，丧偶
		///             4，离婚
		///             5，未说明的婚姻状况]
		/// </summary>
		public MaritalStatusEnum MaritalStatus {get;set;}


		/// <summary>
		/// 【丈夫姓名】
		/// </summary>
		[MaxLength(50)]
		public string HusName {get;set;}


		/// <summary>
		/// 【丈夫证件类型】[1，身份证
		///             2，军官证
		///             4，护照]
		/// </summary>
		public HusIdTypeEnum HusIdType {get;set;}


		/// <summary>
		/// 【丈夫证件号】
		/// </summary>
		[MaxLength(50)]
		public string HusIDNumber {get;set;}


		/// <summary>
		/// 【丈夫年龄】
		/// </summary>
		public int? HusAge {get;set;}


		/// <summary>
		/// 【丈夫手机号】
		/// </summary>
		[MaxLength(50)]
		public string HusPhone {get;set;}


		/// <summary>
		/// 【丈夫国籍】
		/// </summary>
		[MaxLength(50)]
		public string HusCountry {get;set;}


		/// <summary>
		/// 【丈夫民族】
		/// </summary>
		public int? HusRace {get;set;}


		/// <summary>
		/// 【丈夫文化程度】[0，研究生
		///             2，博士后
		///             3，博士
		///             4，硕士
		///             10，本科
		///             20，专科
		///             30，中专
		///             50，高中
		///             60，初中
		///             70，小学
		///             ]
		/// </summary>
		public HusEducationalEnum HusEducational {get;set;}


		/// <summary>
		/// 【丈夫职业】[0，国家机关、党群组织、企业、事业单位负责人
		///             1，专业技术人员 
		///             2，办事人员和有关人员
		///             3，商业、服务业人员
		///             4，农、林、牧、渔、水利业生产人员
		///             5，生产、运输设备操作人员及有关人员
		///             6，军人
		///             7，不便分类的其他从业人员
		///             8，无职业
		///             ]
		/// </summary>
		public HusProfessionEnum HusProfession {get;set;}


		/// <summary>
		/// 【初潮】初潮年龄
		/// </summary>
		public int? MenarcheAge {get;set;}


		/// <summary>
		/// 【月经是否规律】
		/// </summary>
		public byte? IsMenstrualRegularity {get;set;}


		/// <summary>
		/// 【是否吸烟】
		/// </summary>
		public byte? IsSmoke {get;set;}


		/// <summary>
		/// 【是否饮酒】
		/// </summary>
		public byte? IsDrink {get;set;}


		/// <summary>
		/// 【是否有过敏史】
		/// </summary>
		public byte? IsAllergy {get;set;}


		/// <summary>
		/// 【过敏源】01	镇静麻醉剂过敏
		///             02	动物毛发过敏
		///             03	抗生素过敏
		///             031	青霉素过敏
		///             032	链霉素过敏
		///             033	磺胺过敏
		///             04	柑橘类水果过敏
		///             05	室内灰尘过敏
		///             06	鸡蛋过敏
		///             07	鱼及贝壳类食物过敏
		///             08	碘过敏
		///             09	牛奶过敏
		///             10	带壳的果仁过敏
		///             11	花粉过敏
		///             99	其他过敏
		///             
		/// </summary>
		[MaxLength(200)]
		public string Allergen {get;set;}


		/// <summary>
		/// 【其他过敏源】
		/// </summary>
		[MaxLength(50)]
		public string OtherAllergen {get;set;}


		/// <summary>
		/// 【月经史】
		/// </summary>
		[MaxLength(500)]
		public string MenstrualHistory {get;set;}


		/// <summary>
		/// 【检查前情况】
		/// </summary>
		[MaxLength(1000)]
		public string Examination {get;set;}


		/// <summary>
		/// 【既往史】
		/// </summary>
		[MaxLength(500)]
		public string PastHistory {get;set;}


		/// <summary>
		/// 【孕产史】
		/// </summary>
		[MaxLength(500)]
		public string GestationHistory {get;set;}


		/// <summary>
		/// 【家族史】
		/// </summary>
		[MaxLength(500)]
		public string FamilyHistory {get;set;}


		/// <summary>
		/// 【其他既往史】
		/// </summary>
		[MaxLength(50)]
		public string OtherPast {get;set;}


		/// <summary>
		/// 【其他家族史】
		/// </summary>
		[MaxLength(50)]
		public string OtherFamilyHistory {get;set;}


		/// <summary>
		/// 【其他手术史】
		/// </summary>
		[MaxLength(50)]
		public string OtherSurgery {get;set;}


		/// <summary>
		/// 【建档时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【建档医院】
		/// </summary>
		[MaxLength(50)]
		public string Hospital {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【产检记录】
		/// </summary>
		public virtual ICollection<ArchiveRecords> ArchiveRecords {get;set;}



	}
}
