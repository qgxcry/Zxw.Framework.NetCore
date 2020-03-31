using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【检查报告】
	/// </summary>
	public partial class CheckReportsDto
	{
		/// <summary>
		/// 【检查报告ID】
		/// </summary>
		public long? CheckReportID {get;set;}


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
		/// 【科室】
		/// </summary>
		public string Deparment {get;set;}


		/// <summary>
		/// 【编号】
		/// </summary>
		public string ReportNo {get;set;}


		/// <summary>
		/// 【报告名称】
		/// </summary>
		public string ReportName {get;set;}


		/// <summary>
		/// 【报告类型】
		/// </summary>
		public byte? ReportType {get;set;}


		/// <summary>
		/// 【报告时间】
		/// </summary>
		public DateTime? ReportTime {get;set;}


		/// <summary>
		/// 【报告数据】
		/// </summary>
		public string ReportData {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}



	}
}
