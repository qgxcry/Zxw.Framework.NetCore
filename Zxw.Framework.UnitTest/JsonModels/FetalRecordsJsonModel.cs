using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【胎动记录】
	/// </summary>
	public partial class FetalRecordsModel
	{
		/// <summary>
		/// 【胎动记录ID】
		/// </summary>
		[JsonProperty("胎动记录ID")]
		public long? FetalRecordID {get;set;}


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
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}


		/// <summary>
		/// 【孕周】
		/// </summary>
		[JsonProperty("孕周")]
		public int? Week {get;set;}


		/// <summary>
		/// 【孕天】
		/// </summary>
		[JsonProperty("孕天")]
		public int? Day {get;set;}


		/// <summary>
		/// 【早】
		/// </summary>
		[JsonProperty("早")]
		public int? Morning {get;set;}


		/// <summary>
		/// 【中】
		/// </summary>
		[JsonProperty("中")]
		public int? Noon {get;set;}


		/// <summary>
		/// 【晚】
		/// </summary>
		[JsonProperty("晚")]
		public int? Night {get;set;}


		/// <summary>
		/// 【12小时胎动总数】
		/// </summary>
		[JsonProperty("12小时胎动总数")]
		public int? Total {get;set;}


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
