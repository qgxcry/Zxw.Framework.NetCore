using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【高危因素记录】
	/// </summary>
	[Table("HighRiskRecords")]
	public partial class HighRiskRecords:BaseEntity
	{
		/// <summary>
		/// 【ID】
		/// </summary>
		[Key]
		public  long HighRiskRecordID {get;set;}


		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		public long? HighRiskFactorID {get;set;}
		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		[ForeignKey("HighRiskFactorID")]
		public virtual HighRiskFactor HighRiskFactor {get;set;}


		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		public long? ArchiveRecordID {get;set;}
		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		[ForeignKey("ArchiveRecordID")]
		public virtual ArchiveRecords ArchiveRecords {get;set;}


		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public long? ArchiveID {get;set;}
		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		[ForeignKey("ArchiveID")]
		public virtual Archives Archives {get;set;}


		/// <summary>
		/// 【是否自评】
		/// </summary>
		public byte? IsSelf {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【创建时间】
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
