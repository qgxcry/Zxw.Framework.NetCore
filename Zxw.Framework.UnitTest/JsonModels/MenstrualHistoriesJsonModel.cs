using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【月经史】
	/// </summary>
	public partial class MenstrualHistoriesModel
	{
		/// <summary>
		/// 【月经史ID】
		/// </summary>
		[JsonProperty("月经史ID")]
		public long? MenstrualHistoryID {get;set;}


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
		/// 【预产期】
		/// </summary>
		[JsonProperty("预产期")]
		public DateTime? DueDate {get;set;}


		/// <summary>
		/// 【末次月经】最后一次开始来月经的日期
		/// </summary>
		[JsonProperty("末次月经")]
		public DateTime? LastMenstrualDate {get;set;}


		/// <summary>
		/// 【月经周期最小值】
		/// </summary>
		[JsonProperty("月经周期最小值")]
		public int? MenstrualCycleMin {get;set;}


		/// <summary>
		/// 【月经周期最大值】
		/// </summary>
		[JsonProperty("月经周期最大值")]
		public int? MenstrualCycleMax {get;set;}


		/// <summary>
		/// 【月经周期】月经周期是指两次月经第1日的时间间隔
		/// </summary>
		[JsonProperty("月经周期")]
		public int? MenstrualCycle {get;set;}


		/// <summary>
		/// 【经期最小值】
		/// </summary>
		[JsonProperty("经期最小值")]
		public int? MenstrualPeriodMin {get;set;}


		/// <summary>
		/// 【经期最大值】
		/// </summary>
		[JsonProperty("经期最大值")]
		public int? MenstrualPeriodMax {get;set;}


		/// <summary>
		/// 【经期】月经期是指每次月经持续的天数
		/// </summary>
		[JsonProperty("经期")]
		public int? MenstrualPeriod {get;set;}


		/// <summary>
		/// 【初潮年龄】
		/// </summary>
		[JsonProperty("初潮年龄")]
		public int? MenarcheAge {get;set;}


		/// <summary>
		/// 【月经是否规律】
		/// </summary>
		[JsonProperty("月经是否规律")]
		public byte? IsMenstrualRegularity {get;set;}


		/// <summary>
		/// 【月经量】[1，多
		///             2，中
		///             3，少]
		/// </summary>
		[JsonProperty("月经量")]
		public MenarcheBVEnum? MenarcheBV {get;set;}


		/// <summary>
		/// 【痛经】[0，无
		///             1，轻
		///             2，中
		///             3，重]
		/// </summary>
		[JsonProperty("痛经")]
		public DysmenorrheaEnum? Dysmenorrhea {get;set;}


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
