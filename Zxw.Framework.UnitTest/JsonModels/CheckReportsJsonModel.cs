using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【检查报告】
	/// </summary>
	public partial class CheckReportsModel
	{
		/// <summary>
		/// 【检查报告ID】
		/// </summary>
		[JsonProperty("检查报告ID")]
		public long CheckReportID {get;set;}


		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		[JsonProperty("产检记录ID")]
		public long? ArchiveRecordID {get;set;}
		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		public virtual ArchiveRecordsJsonModel ArchiveRecords {get;set;}


		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		[JsonProperty("产检档案ID")]
		public long? ArchiveID {get;set;}
		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public virtual ArchivesJsonModel Archives {get;set;}


		/// <summary>
		/// 【科室】
		/// </summary>
		[JsonProperty("科室")]
		public string Deparment {get;set;}


		/// <summary>
		/// 【编号】
		/// </summary>
		[JsonProperty("编号")]
		public string ReportNo {get;set;}


		/// <summary>
		/// 【报告名称】
		/// </summary>
		[JsonProperty("报告名称")]
		public string ReportName {get;set;}


		/// <summary>
		/// 【报告类型】
		/// </summary>
		[JsonProperty("报告类型")]
		public byte? ReportType {get;set;}


		/// <summary>
		/// 【报告时间】
		/// </summary>
		[JsonProperty("报告时间")]
		public DateTime? ReportTime {get;set;}


		/// <summary>
		/// 【报告数据】
		/// </summary>
		[JsonProperty("报告数据")]
		public string ReportData {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}



	}
}
