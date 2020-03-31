using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【检查前情况】
	/// </summary>
	public partial class ExaminationInfoModel
	{
		/// <summary>
		/// 【妊娠前情况ID】
		/// </summary>
		[JsonProperty("妊娠前情况ID")]
		public long? PrePregnancyInfoID {get;set;}


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
		/// 【是否口服叶酸】
		/// </summary>
		[JsonProperty("是否口服叶酸")]
		public byte? IsOralFolicAcid {get;set;}


		/// <summary>
		/// 【HCG阳性停经天数】末次月经到通过HCG检查确定怀孕的天数
		/// </summary>
		[JsonProperty("HCG阳性停经天数")]
		public int? HCGPositiveDays {get;set;}


		/// <summary>
		/// 【是否发热】
		/// </summary>
		[JsonProperty("是否发热")]
		public byte? IsHeat {get;set;}


		/// <summary>
		/// 【阴道出血】
		/// </summary>
		[JsonProperty("阴道出血")]
		public byte? IsVaginalBleeding {get;set;}


		/// <summary>
		/// 【接触物理性有害因素】[0，无
		///             1，噪声
		///             2，震动
		///             3，X射线
		///             4，电磁辐射
		///             5，高温
		///             6，极低温度
		///             7，微波
		///             8，其他]
		/// </summary>
		[JsonProperty("接触物理性有害因素")]
		public string PhysicalHarmfuls {get;set;}


		/// <summary>
		/// 【其他物理有害因素】
		/// </summary>
		[JsonProperty("其他物理有害因素")]
		public string OtherPhysical {get;set;}


		/// <summary>
		/// 【接触高浓度工业毒物】[0，无
		///             1，重金属
		///             2，农药
		///             3，有机溶剂
		///             4，制药
		///             5，其他
		///             ]
		/// </summary>
		[JsonProperty("接触高浓度工业毒物")]
		public string IndustrialPoisons {get;set;}


		/// <summary>
		/// 【其他高浓度工业毒物】
		/// </summary>
		[JsonProperty("其他高浓度工业毒物")]
		public string OtherIndustria {get;set;}


		/// <summary>
		/// 【环境新装修】
		/// </summary>
		[JsonProperty("环境新装修")]
		public byte? IsNewDecoration {get;set;}


		/// <summary>
		/// 【家养宠物】
		/// </summary>
		[JsonProperty("家养宠物")]
		public byte? IsKeepPet {get;set;}


		/// <summary>
		/// 【烟龄】
		/// </summary>
		[JsonProperty("烟龄")]
		public int? SmokeAge {get;set;}


		/// <summary>
		/// 【每天平均多少支】
		/// </summary>
		[JsonProperty("每天平均多少支")]
		public int? SmokeTimes {get;set;}


		/// <summary>
		/// 【饮酒量】
		/// </summary>
		[JsonProperty("饮酒量")]
		public int? DrinkML {get;set;}


		/// <summary>
		/// 【是否饮酒】
		/// </summary>
		[JsonProperty("是否饮酒")]
		public byte? IsDrink {get;set;}


		/// <summary>
		/// 【是否吸烟】
		/// </summary>
		[JsonProperty("是否吸烟")]
		public byte? IsSomke {get;set;}


		/// <summary>
		/// 【是否吸毒】0，无
		///             1，有
		/// </summary>
		[JsonProperty("是否吸毒")]
		public byte? IsDrug {get;set;}


		/// <summary>
		/// 【建档时间】
		/// </summary>
		[JsonProperty("建档时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		[JsonProperty("更新时间")]
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}



	}
}
