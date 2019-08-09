using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【高危因素记录】
	/// </summary>
	public partial class HighRiskRecordsViewModel
	{
		/// <summary>
		/// 【ID】
		/// </summary>
		[Required]
		public long HighRiskRecordID {get;set;}


		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		public long? HighRiskFactorID {get;set;}
		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		public virtual HighRiskFactorViewModel HighRiskFactor {get;set;}


		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		public long? ArchiveRecordID {get;set;}
		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		public virtual ArchiveRecordsViewModel ArchiveRecords {get;set;}


		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public long? ArchiveID {get;set;}
		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public virtual ArchivesViewModel Archives {get;set;}


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
