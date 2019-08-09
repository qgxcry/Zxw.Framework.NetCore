using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【高危因素】
	/// </summary>
	public partial class HighRiskFactorModel
	{
		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		[JsonProperty("高危因素ID")]
		public long HighRiskFactorID {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[JsonProperty("名称")]
		public string Name {get;set;}


		/// <summary>
		/// 【简码】
		/// </summary>
		[JsonProperty("简码")]
		public string SortCode {get;set;}


		/// <summary>
		/// 【层级代码】
		/// </summary>
		[JsonProperty("层级代码")]
		public string IndexCode {get;set;}


		/// <summary>
		/// 【上级ID】
		/// </summary>
		[JsonProperty("上级ID")]
		public long? ParentID {get;set;}


		/// <summary>
		/// 【是否是子节点】
		/// </summary>
		[JsonProperty("是否是子节点")]
		public byte? IsChildren {get;set;}


		/// <summary>
		/// 【排序】
		/// </summary>
		[JsonProperty("排序")]
		public int? Sort {get;set;}


		/// <summary>
		/// 【产生的影响】
		/// </summary>
		[JsonProperty("产生的影响")]
		public string Effect {get;set;}


		/// <summary>
		/// 【干预指导方案】
		/// </summary>
		[JsonProperty("干预指导方案")]
		public string TreatPlan {get;set;}


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


		/// <summary>
		/// 【高危因素记录】
		/// </summary>
		public virtual ICollection<HighRiskRecordsJsonModel> HighRiskRecords {get;set;}



	}
}
