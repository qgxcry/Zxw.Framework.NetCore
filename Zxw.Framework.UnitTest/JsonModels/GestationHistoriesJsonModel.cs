using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【孕产史】
	/// </summary>
	public partial class GestationHistoriesModel
	{
		/// <summary>
		/// 【孕产史ID】
		/// </summary>
		[JsonProperty("孕产史ID")]
		public long GestationHistoryID {get;set;}


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
		/// 【怀孕次数】
		/// </summary>
		[JsonProperty("怀孕次数")]
		public int? PregnancyTimes {get;set;}


		/// <summary>
		/// 【生产次数】
		/// </summary>
		[JsonProperty("生产次数")]
		public int? BirthTimes {get;set;}


		/// <summary>
		/// 【阴道产次数】
		/// </summary>
		[JsonProperty("阴道产次数")]
		public int? VaginalDeliveryTimes {get;set;}


		/// <summary>
		/// 【剖宫产次数】
		/// </summary>
		[JsonProperty("剖宫产次数")]
		public int? CaesareanDeliveryTimes {get;set;}


		/// <summary>
		/// 【女孩个数】
		/// </summary>
		[JsonProperty("女孩个数")]
		public int? Girls {get;set;}


		/// <summary>
		/// 【男孩个数】
		/// </summary>
		[JsonProperty("男孩个数")]
		public int? Boys {get;set;}


		/// <summary>
		/// 【自然流产次数】
		/// </summary>
		[JsonProperty("自然流产次数")]
		public int? MiscarriageTimes {get;set;}


		/// <summary>
		/// 【人工流产次数】
		/// </summary>
		[JsonProperty("人工流产次数")]
		public int? AbortionTimes {get;set;}


		/// <summary>
		/// 【早产次数】
		/// </summary>
		[JsonProperty("早产次数")]
		public int? PrematureLaborTimes {get;set;}


		/// <summary>
		/// 【死胎（产）次数】
		/// </summary>
		[JsonProperty("死胎（产）次数")]
		public int? StillBirthTimes {get;set;}


		/// <summary>
		/// 【新生儿死亡次数】
		/// </summary>
		[JsonProperty("新生儿死亡次数")]
		public int? NewbornDeathTimes {get;set;}


		/// <summary>
		/// 【末次流产】
		/// </summary>
		[JsonProperty("末次流产")]
		public DateTime? LastAbortionDate {get;set;}


		/// <summary>
		/// 【末次分娩】
		/// </summary>
		[JsonProperty("末次分娩")]
		public DateTime? LastBirthDate {get;set;}


		/// <summary>
		/// 【既往出生缺陷】
		/// </summary>
		[JsonProperty("既往出生缺陷")]
		public byte? IsBirthDefect {get;set;}


		/// <summary>
		/// 【既往妊娠合并症、并发症】
		/// </summary>
		[JsonProperty("既往妊娠合并症、并发症")]
		public byte? IsComplication {get;set;}


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
