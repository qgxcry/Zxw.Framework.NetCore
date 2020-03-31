using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【站点】
	/// </summary>
	public partial class SitesModel
	{
		/// <summary>
		/// 【站点ID】
		/// </summary>
		[JsonProperty("站点ID")]
		public string Id {get;set;}


		/// <summary>
		/// 【Site】
		/// </summary>
		[JsonProperty("Site")]
		public string SiteName {get;set;}


		/// <summary>
		/// 【Code】
		/// </summary>
		[JsonProperty("Code")]
		public string SiteCode {get;set;}


		/// <summary>
		/// 【Url】
		/// </summary>
		[JsonProperty("Url")]
		public string SiteUrl {get;set;}


		/// <summary>
		/// 【CreateTime】
		/// </summary>
		[JsonProperty("CreateTime")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【UpdateTime】
		/// </summary>
		[JsonProperty("UpdateTime")]
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【IsDeleted】
		/// </summary>
		[JsonProperty("IsDeleted")]
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【IsEnabled】
		/// </summary>
		[JsonProperty("IsEnabled")]
		public byte? IsEnabled {get;set;}



	}
}
