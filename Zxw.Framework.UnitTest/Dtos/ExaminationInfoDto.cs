using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【检查前情况】
	/// </summary>
	public partial class ExaminationInfoDto
	{
		/// <summary>
		/// 【妊娠前情况ID】
		/// </summary>
		public long? PrePregnancyInfoID {get;set;}


		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		public long? PersonArchiveID {get;set;}
		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		public virtual PersonArchivesDto PersonArchives {get;set;}


		/// <summary>
		/// 【是否口服叶酸】
		/// </summary>
		public byte? IsOralFolicAcid {get;set;}


		/// <summary>
		/// 【HCG阳性停经天数】末次月经到通过HCG检查确定怀孕的天数
		/// </summary>
		public int? HCGPositiveDays {get;set;}


		/// <summary>
		/// 【是否发热】
		/// </summary>
		public byte? IsHeat {get;set;}


		/// <summary>
		/// 【阴道出血】
		/// </summary>
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
		public string PhysicalHarmfuls {get;set;}


		/// <summary>
		/// 【其他物理有害因素】
		/// </summary>
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
		public string IndustrialPoisons {get;set;}


		/// <summary>
		/// 【其他高浓度工业毒物】
		/// </summary>
		public string OtherIndustria {get;set;}


		/// <summary>
		/// 【环境新装修】
		/// </summary>
		public byte? IsNewDecoration {get;set;}


		/// <summary>
		/// 【家养宠物】
		/// </summary>
		public byte? IsKeepPet {get;set;}


		/// <summary>
		/// 【烟龄】
		/// </summary>
		public int? SmokeAge {get;set;}


		/// <summary>
		/// 【每天平均多少支】
		/// </summary>
		public int? SmokeTimes {get;set;}


		/// <summary>
		/// 【饮酒量】
		/// </summary>
		public int? DrinkML {get;set;}


		/// <summary>
		/// 【是否饮酒】
		/// </summary>
		public byte? IsDrink {get;set;}


		/// <summary>
		/// 【是否吸烟】
		/// </summary>
		public byte? IsSomke {get;set;}


		/// <summary>
		/// 【是否吸毒】0，无
		///             1，有
		/// </summary>
		public byte? IsDrug {get;set;}


		/// <summary>
		/// 【建档时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}



	}
}
