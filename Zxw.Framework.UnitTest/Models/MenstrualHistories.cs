using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【月经史】
	/// </summary>
	[Table("MenstrualHistories")]
	public partial class MenstrualHistories:BaseEntity
	{
		/// <summary>
		/// 【月经史ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  long MenstrualHistoryID {get;set;}


		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		public long? PersonArchiveID {get;set;}
		/// <summary>
		/// 【个人档案ID】
		/// </summary>
		[ForeignKey("PersonArchiveID")]
		public virtual PersonArchives PersonArchives {get;set;}


		/// <summary>
		/// 【预产期】
		/// </summary>
		public DateTime? DueDate {get;set;}


		/// <summary>
		/// 【末次月经】最后一次开始来月经的日期
		/// </summary>
		public DateTime? LastMenstrualDate {get;set;}


		/// <summary>
		/// 【月经周期最小值】
		/// </summary>
		public int? MenstrualCycleMin {get;set;}


		/// <summary>
		/// 【月经周期最大值】
		/// </summary>
		public int? MenstrualCycleMax {get;set;}


		/// <summary>
		/// 【月经周期】月经周期是指两次月经第1日的时间间隔
		/// </summary>
		public int? MenstrualCycle {get;set;}


		/// <summary>
		/// 【经期最小值】
		/// </summary>
		public int? MenstrualPeriodMin {get;set;}


		/// <summary>
		/// 【经期最大值】
		/// </summary>
		public int? MenstrualPeriodMax {get;set;}


		/// <summary>
		/// 【经期】月经期是指每次月经持续的天数
		/// </summary>
		public int? MenstrualPeriod {get;set;}


		/// <summary>
		/// 【初潮年龄】
		/// </summary>
		public int? MenarcheAge {get;set;}


		/// <summary>
		/// 【月经是否规律】
		/// </summary>
		public byte? IsMenstrualRegularity {get;set;}


		/// <summary>
		/// 【月经量】[1，多
		///             2，中
		///             3，少]
		/// </summary>
		public MenarcheBVEnum? MenarcheBV {get;set;}


		/// <summary>
		/// 【痛经】[0，无
		///             1，轻
		///             2，中
		///             3，重]
		/// </summary>
		public DysmenorrheaEnum? Dysmenorrhea {get;set;}


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
