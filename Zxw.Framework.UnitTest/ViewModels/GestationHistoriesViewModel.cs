using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Web.Models
{
	/// <summary>
	/// 【孕产史】
	/// </summary>
	public partial class GestationHistoriesViewModel
	{
		/// <summary>
		/// 【孕产史ID】
		/// </summary>
		public long? GestationHistoryID {get;set;}


		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		public long? PersonArchiveID {get;set;}
		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		public virtual PersonArchivesViewModel PersonArchives {get;set;}


		/// <summary>
		/// 【怀孕次数】
		/// </summary>
		public int? PregnancyTimes {get;set;}


		/// <summary>
		/// 【生产次数】
		/// </summary>
		public int? BirthTimes {get;set;}


		/// <summary>
		/// 【阴道产次数】
		/// </summary>
		public int? VaginalDeliveryTimes {get;set;}


		/// <summary>
		/// 【剖宫产次数】
		/// </summary>
		public int? CaesareanDeliveryTimes {get;set;}


		/// <summary>
		/// 【女孩个数】
		/// </summary>
		public int? Girls {get;set;}


		/// <summary>
		/// 【男孩个数】
		/// </summary>
		public int? Boys {get;set;}


		/// <summary>
		/// 【自然流产次数】
		/// </summary>
		public int? MiscarriageTimes {get;set;}


		/// <summary>
		/// 【人工流产次数】
		/// </summary>
		public int? AbortionTimes {get;set;}


		/// <summary>
		/// 【早产次数】
		/// </summary>
		public int? PrematureLaborTimes {get;set;}


		/// <summary>
		/// 【死胎（产）次数】
		/// </summary>
		public int? StillBirthTimes {get;set;}


		/// <summary>
		/// 【新生儿死亡次数】
		/// </summary>
		public int? NewbornDeathTimes {get;set;}


		/// <summary>
		/// 【末次流产】
		/// </summary>
		public DateTime? LastAbortionDate {get;set;}


		/// <summary>
		/// 【末次分娩】
		/// </summary>
		public DateTime? LastBirthDate {get;set;}


		/// <summary>
		/// 【既往出生缺陷】
		/// </summary>
		public byte? IsBirthDefect {get;set;}


		/// <summary>
		/// 【既往妊娠合并症、并发症】
		/// </summary>
		public byte? IsComplication {get;set;}


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
