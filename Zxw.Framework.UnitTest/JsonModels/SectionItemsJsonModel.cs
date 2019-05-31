using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【栏目配置项】
	/// </summary>
	public partial class SectionItemsModel
	{
		/// <summary>
		/// 【栏目配置项ID】
		/// </summary>
		[JsonProperty("栏目配置项ID")]
		public int SectionItemID {get;set;}


		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		[JsonProperty("栏目配置ID")]
		public int? SectionID {get;set;}
		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		public virtual SectionsJsonModel Sections {get;set;}


		/// <summary>
		/// 【图标】
		/// </summary>
		[JsonProperty("图标")]
		public string Icon {get;set;}


		/// <summary>
		/// 【颜色】
		/// </summary>
		[JsonProperty("颜色")]
		public string Color {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[JsonProperty("名称")]
		public string Title {get;set;}


		/// <summary>
		/// 【是否站外链接】
		/// </summary>
		[JsonProperty("是否站外链接")]
		public byte? IsOutLink {get;set;}


		/// <summary>
		/// 【链接】
		/// </summary>
		[JsonProperty("链接")]
		public string Url {get;set;}


		/// <summary>
		/// 【内容】
		/// </summary>
		[JsonProperty("内容")]
		public string Content {get;set;}


		/// <summary>
		/// 【排序号】
		/// </summary>
		[JsonProperty("排序号")]
		public int? Sort {get;set;}


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
