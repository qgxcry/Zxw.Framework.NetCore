using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【栏目配置】
	/// </summary>
	public partial class SectionsModel
	{
		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		[JsonProperty("栏目配置ID")]
		public int? SectionID {get;set;}


		/// <summary>
		/// 【公众号站点ID】
		/// </summary>
		[JsonProperty("公众号站点ID")]
		public int? SiteID {get;set;}
		/// <summary>
		/// 【公众号站点ID】
		/// </summary>
		public virtual SitesJsonModel Sites {get;set;}


		/// <summary>
		/// 【栏目标题】
		/// </summary>
		[JsonProperty("栏目标题")]
		public string Title {get;set;}


		/// <summary>
		/// 【栏目类型】0，图标
		///             1，色块
		///             2，列表
		/// </summary>
		[JsonProperty("栏目类型")]
		public byte? Type {get;set;}


		/// <summary>
		/// 【是否显示标题】
		/// </summary>
		[JsonProperty("是否显示标题")]
		public byte? IsShowTitle {get;set;}


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
		/// 【栏目配置项】
		/// </summary>
		public virtual ICollection<SectionItemsJsonModel> SectionItems {get;set;}



	}
}
