using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【高危因素记录】
	/// </summary>
	public partial class HighRiskRecordsDto
	{
		/// <summary>
		/// 【ID】
		/// </summary>
		public long? HighRiskRecordID {get;set;}


		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		public long? HighRiskFactorID {get;set;}
		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		public virtual HighRiskFactorDto HighRiskFactor {get;set;}


		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public long? GestationRecordID {get;set;}
		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public virtual GestationRecordsDto GestationRecords {get;set;}


		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		public long? ArchiveRecordID {get;set;}
		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		public virtual ArchiveRecordsDto ArchiveRecords {get;set;}


		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public long? ArchiveID {get;set;}
		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public virtual ArchivesDto Archives {get;set;}


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
