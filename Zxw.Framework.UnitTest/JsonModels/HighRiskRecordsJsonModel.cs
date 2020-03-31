using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【高危因素记录】
	/// </summary>
	public partial class HighRiskRecordsModel
	{
		/// <summary>
		/// 【ID】
		/// </summary>
		[JsonProperty("ID")]
		public long? HighRiskRecordID {get;set;}


		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		[JsonProperty("高危因素ID")]
		public long? HighRiskFactorID {get;set;}
		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		public virtual HighRiskFactorJsonModel HighRiskFactor {get;set;}


		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		[JsonProperty("孕期记录ID")]
		public long? GestationRecordID {get;set;}
		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public virtual GestationRecordsJsonModel GestationRecords {get;set;}


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
		/// 【是否自评】
		/// </summary>
		[JsonProperty("是否自评")]
		public byte? IsSelf {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
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
