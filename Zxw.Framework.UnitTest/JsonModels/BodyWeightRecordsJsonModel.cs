using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【体重管理】
	/// </summary>
	public partial class BodyWeightRecordsModel
	{
		/// <summary>
		/// 【ID】
		/// </summary>
		[JsonProperty("ID")]
		public long BodyWeightRecordID {get;set;}


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
		/// 【体重】
		/// </summary>
		[JsonProperty("体重")]
		public decimal? Weight {get;set;}


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
