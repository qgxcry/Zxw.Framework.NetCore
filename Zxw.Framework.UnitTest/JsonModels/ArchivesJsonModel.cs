using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【产检档案】
	/// </summary>
	public partial class ArchivesModel
	{
		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		[JsonProperty("产检档案ID")]
		public long? ArchiveID {get;set;}


		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		[JsonProperty("孕期记录ID")]
		public long? GestationRecordID {get;set;}
		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public virtual GestationRecordsJsonModel GestationRecords {get;set;}


		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		[JsonProperty("个人档案ID")]
		public long? PersonArchiveID {get;set;}
		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		public virtual PersonArchivesJsonModel PersonArchives {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}


		/// <summary>
		/// 【卡号】
		/// </summary>
		[JsonProperty("卡号")]
		public string CardNo {get;set;}


		/// <summary>
		/// 【孕妇编号】
		/// </summary>
		[JsonProperty("孕妇编号")]
		public string UserNo {get;set;}


		/// <summary>
		/// 【产检档案编号】
		/// </summary>
		[JsonProperty("产检档案编号")]
		public string ArchiveNo {get;set;}


		/// <summary>
		/// 【孕检状态】[0，已建档
		///             1，孕检中
		///             2，已分娩
		///             3，已结案
		///             ]
		///             
		/// </summary>
		[JsonProperty("孕检状态")]
		public ArchiveStatusEnum? ArchiveStatus {get;set;}


		/// <summary>
		/// 【孕妇姓名】
		/// </summary>
		[JsonProperty("孕妇姓名")]
		public string Name {get;set;}


		/// <summary>
		/// 【姓名拼音】
		/// </summary>
		[JsonProperty("姓名拼音")]
		public string NamePinYin {get;set;}


		/// <summary>
		/// 【姓名简拼】
		/// </summary>
		[JsonProperty("姓名简拼")]
		public string NameJianPin {get;set;}


		/// <summary>
		/// 【证件类型】[1，身份证
		///             2，军官证
		///             4，护照]
		/// </summary>
		[JsonProperty("证件类型")]
		public IdTypeEnum? IdType {get;set;}


		/// <summary>
		/// 【证件号】
		/// </summary>
		[JsonProperty("证件号")]
		public string IDNumber {get;set;}


		/// <summary>
		/// 【孕前体重】
		/// </summary>
		[JsonProperty("孕前体重")]
		public decimal? BodyWeight {get;set;}


		/// <summary>
		/// 【身高】
		/// </summary>
		[JsonProperty("身高")]
		public decimal? Stature {get;set;}


		/// <summary>
		/// 【出生日期】
		/// </summary>
		[JsonProperty("出生日期")]
		public DateTime? BornDate {get;set;}


		/// <summary>
		/// 【当前孕期】0，否
		///             1，是
		/// </summary>
		[JsonProperty("当前孕期")]
		public byte? IsCurrent {get;set;}


		/// <summary>
		/// 【结婚年龄】
		/// </summary>
		[JsonProperty("结婚年龄")]
		public int? MarriageAge {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		[JsonProperty("手机号")]
		public string Phone {get;set;}


		/// <summary>
		/// 【民族】
		/// </summary>
		[JsonProperty("民族")]
		public int? Race {get;set;}


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
		[JsonProperty("文化程度")]
		public EducationalEnum? Educational {get;set;}


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
		[JsonProperty("职业")]
		public ProfessionEnum? Profession {get;set;}


		/// <summary>
		/// 【工作单位】
		/// </summary>
		[JsonProperty("工作单位")]
		public string Employer {get;set;}


		/// <summary>
		/// 【是否愿意自然分娩】1，自然分娩
		///             0，不愿意自然分娩
		/// </summary>
		[JsonProperty("是否愿意自然分娩")]
		public byte? IsNatural {get;set;}


		/// <summary>
		/// 【现住省份】
		/// </summary>
		[JsonProperty("现住省份")]
		public string Province {get;set;}


		/// <summary>
		/// 【现住城市】
		/// </summary>
		[JsonProperty("现住城市")]
		public string City {get;set;}


		/// <summary>
		/// 【现住区县】
		/// </summary>
		[JsonProperty("现住区县")]
		public string District {get;set;}


		/// <summary>
		/// 【现住居委会】
		/// </summary>
		[JsonProperty("现住居委会")]
		public string Community {get;set;}


		/// <summary>
		/// 【休养省份】
		/// </summary>
		[JsonProperty("休养省份")]
		public string RestProvince {get;set;}


		/// <summary>
		/// 【现住地址】
		/// </summary>
		[JsonProperty("现住地址")]
		public string CurrAddress {get;set;}


		/// <summary>
		/// 【现住地址详情】
		/// </summary>
		[JsonProperty("现住地址详情")]
		public string CurrAddressInfo {get;set;}


		/// <summary>
		/// 【现住乡镇】
		/// </summary>
		[JsonProperty("现住乡镇")]
		public string Village {get;set;}


		/// <summary>
		/// 【休养城市】
		/// </summary>
		[JsonProperty("休养城市")]
		public string RestCity {get;set;}


		/// <summary>
		/// 【休养区县】
		/// </summary>
		[JsonProperty("休养区县")]
		public string RestDistrict {get;set;}


		/// <summary>
		/// 【休养乡镇】
		/// </summary>
		[JsonProperty("休养乡镇")]
		public string RestVillage {get;set;}


		/// <summary>
		/// 【休养居委会】
		/// </summary>
		[JsonProperty("休养居委会")]
		public string RestCommunity {get;set;}


		/// <summary>
		/// 【休养地址】
		/// </summary>
		[JsonProperty("休养地址")]
		public string RestAddress {get;set;}


		/// <summary>
		/// 【休养地址详情】
		/// </summary>
		[JsonProperty("休养地址详情")]
		public string RestAddressInfo {get;set;}


		/// <summary>
		/// 【休养区域ID】
		/// </summary>
		[JsonProperty("休养区域ID")]
		public int? RestAreaID {get;set;}


		/// <summary>
		/// 【区域ID】
		/// </summary>
		[JsonProperty("区域ID")]
		public int? AreaID {get;set;}


		/// <summary>
		/// 【户口区域ID】
		/// </summary>
		[JsonProperty("户口区域ID")]
		public int? RegAreaID {get;set;}


		/// <summary>
		/// 【户口乡镇】
		/// </summary>
		[JsonProperty("户口乡镇")]
		public string RegVillage {get;set;}


		/// <summary>
		/// 【户口居委会】
		/// </summary>
		[JsonProperty("户口居委会")]
		public string RegCommunity {get;set;}


		/// <summary>
		/// 【户口省份】
		/// </summary>
		[JsonProperty("户口省份")]
		public string RegProvince {get;set;}


		/// <summary>
		/// 【户口城市】
		/// </summary>
		[JsonProperty("户口城市")]
		public string RegCity {get;set;}


		/// <summary>
		/// 【户口区县】
		/// </summary>
		[JsonProperty("户口区县")]
		public string RegDistrict {get;set;}


		/// <summary>
		/// 【户口地址】
		/// </summary>
		[JsonProperty("户口地址")]
		public string RegAddress {get;set;}


		/// <summary>
		/// 【户口地址详情】
		/// </summary>
		[JsonProperty("户口地址详情")]
		public string RegAddressInfo {get;set;}


		/// <summary>
		/// 【婚姻状况】[1，未婚
		///             2，已婚
		///             3，丧偶
		///             4，离婚
		///             5，未说明的婚姻状况]
		/// </summary>
		[JsonProperty("婚姻状况")]
		public MaritalStatusEnum? MaritalStatus {get;set;}


		/// <summary>
		/// 【联系人关系】[0，丈夫
		///             1，父母
		///             2，兄、弟、姊、妹
		///             3，其他]
		/// </summary>
		[JsonProperty("联系人关系")]
		public ContactRelationshipEnum? ContactRelationship {get;set;}


		/// <summary>
		/// 【丈夫姓名】
		/// </summary>
		[JsonProperty("丈夫姓名")]
		public string HusName {get;set;}


		/// <summary>
		/// 【丈夫证件类型】[1，身份证
		///             2，军官证
		///             4，护照]
		/// </summary>
		[JsonProperty("丈夫证件类型")]
		public HusIdTypeEnum? HusIdType {get;set;}


		/// <summary>
		/// 【丈夫证件号】
		/// </summary>
		[JsonProperty("丈夫证件号")]
		public string HusIDNumber {get;set;}


		/// <summary>
		/// 【丈夫年龄】
		/// </summary>
		[JsonProperty("丈夫年龄")]
		public int? HusAge {get;set;}


		/// <summary>
		/// 【丈夫手机号】
		/// </summary>
		[JsonProperty("丈夫手机号")]
		public string HusPhone {get;set;}


		/// <summary>
		/// 【丈夫国籍】
		/// </summary>
		[JsonProperty("丈夫国籍")]
		public string HusCountry {get;set;}


		/// <summary>
		/// 【丈夫民族】
		/// </summary>
		[JsonProperty("丈夫民族")]
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
		[JsonProperty("丈夫文化程度")]
		public HusEducationalEnum? HusEducational {get;set;}


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
		[JsonProperty("丈夫职业")]
		public HusProfessionEnum? HusProfession {get;set;}


		/// <summary>
		/// 【丈夫单位】
		/// </summary>
		[JsonProperty("丈夫单位")]
		public string HusEmployer {get;set;}


		/// <summary>
		/// 【丈夫血型ABO】[1，B型
		///             2，O型
		///             3，A型
		///             4，AB型
		///             5，不详]
		/// </summary>
		[JsonProperty("丈夫血型ABO")]
		public HusBloodABOEnum? HusBloodABO {get;set;}


		/// <summary>
		/// 【丈夫血型RH】[1，RH阳性
		///             2，RH阴性
		///             3，不详]
		/// </summary>
		[JsonProperty("丈夫血型RH")]
		public HusBloodRHEnum? HusBloodRH {get;set;}


		/// <summary>
		/// 【丈夫身体情况】[1，壮
		///             2，一般
		///             3，弱]
		/// </summary>
		[JsonProperty("丈夫身体情况")]
		public HusPhysicalConditionEnum? HusPhysicalCondition {get;set;}


		/// <summary>
		/// 【丈夫既往情况】
		/// </summary>
		[JsonProperty("丈夫既往情况")]
		public byte? IsHusPast {get;set;}


		/// <summary>
		/// 【丈夫既往情况异常】
		/// </summary>
		[JsonProperty("丈夫既往情况异常")]
		public string HusPastDisease {get;set;}


		/// <summary>
		/// 【丈夫肺部疾病】
		/// </summary>
		[JsonProperty("丈夫肺部疾病")]
		public byte? IsHusPulmonaryDisease {get;set;}


		/// <summary>
		/// 【丈夫肺部疾病异常】
		/// </summary>
		[JsonProperty("丈夫肺部疾病异常")]
		public string HusPulmonaryDisease {get;set;}


		/// <summary>
		/// 【丈夫肾脏疾病】
		/// </summary>
		[JsonProperty("丈夫肾脏疾病")]
		public byte? IsHusKidneyDisease {get;set;}


		/// <summary>
		/// 【丈夫肾脏疾病异常】
		/// </summary>
		[JsonProperty("丈夫肾脏疾病异常")]
		public string HusKidneyDisease {get;set;}


		/// <summary>
		/// 【丈夫吸烟】
		/// </summary>
		[JsonProperty("丈夫吸烟")]
		public byte? HusSomking {get;set;}


		/// <summary>
		/// 【丈夫饮酒】
		/// </summary>
		[JsonProperty("丈夫饮酒")]
		public byte? HusDrink {get;set;}


		/// <summary>
		/// 【是否有过敏史】
		/// </summary>
		[JsonProperty("是否有过敏史")]
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
		[JsonProperty("过敏源")]
		public string Allergen {get;set;}


		/// <summary>
		/// 【其他过敏源】
		/// </summary>
		[JsonProperty("其他过敏源")]
		public string OtherAllergen {get;set;}


		/// <summary>
		/// 【月经史】
		/// </summary>
		[JsonProperty("月经史")]
		public string MenstrualHistory {get;set;}


		/// <summary>
		/// 【检查前情况】
		/// </summary>
		[JsonProperty("检查前情况")]
		public string Examination {get;set;}


		/// <summary>
		/// 【既往史】
		/// </summary>
		[JsonProperty("既往史")]
		public string PastHistory {get;set;}


		/// <summary>
		/// 【孕产史】
		/// </summary>
		[JsonProperty("孕产史")]
		public string GestationHistory {get;set;}


		/// <summary>
		/// 【家族史】
		/// </summary>
		[JsonProperty("家族史")]
		public string FamilyHistory {get;set;}


		/// <summary>
		/// 【其他既往史】
		/// </summary>
		[JsonProperty("其他既往史")]
		public string OtherPast {get;set;}


		/// <summary>
		/// 【其他家族史】
		/// </summary>
		[JsonProperty("其他家族史")]
		public string OtherFamilyHistory {get;set;}


		/// <summary>
		/// 【其他手术史】
		/// </summary>
		[JsonProperty("其他手术史")]
		public string OtherSurgery {get;set;}


		/// <summary>
		/// 【建档站点ID】
		/// </summary>
		[JsonProperty("建档站点ID")]
		public int? SiteID {get;set;}


		/// <summary>
		/// 【建档时间】
		/// </summary>
		[JsonProperty("建档时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【建档医院】
		/// </summary>
		[JsonProperty("建档医院")]
		public string Hospital {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		[JsonProperty("更新时间")]
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【妇产科手术史】[0，无
		///             1，阴道手术
		///             2，宫颈锥切手术
		///             3，腹腔镜手术
		///             4，子宫肌瘤挖出手术
		///             5，子宫肌腺瘤挖出手术
		///             6，子宫整形术
		///             7，附件恶性肿瘤手术
		///             8，其他
		///             ]
		///             
		/// </summary>
		[JsonProperty("妇产科手术史")]
		public string SurgeryHistory {get;set;}


		/// <summary>
		/// 【产检记录】
		/// </summary>
		public virtual ICollection<ArchiveRecordsJsonModel> ArchiveRecords {get;set;}


		/// <summary>
		/// 【检查报告】
		/// </summary>
		public virtual ICollection<CheckReportsJsonModel> CheckReports {get;set;}


		/// <summary>
		/// 【高危因素记录】
		/// </summary>
		public virtual ICollection<HighRiskRecordsJsonModel> HighRiskRecords {get;set;}



	}
}
