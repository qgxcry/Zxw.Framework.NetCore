using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【栏目配置项】
	/// </summary>
	public partial class SectionItemsDto
	{
		/// <summary>
		/// 【栏目配置项ID】
		/// </summary>
		public int SectionItemID {get;set;}


		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		public int? SectionID {get;set;}
		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		public virtual SectionsDto Sections {get;set;}


		/// <summary>
		/// 【图标】
		/// </summary>
		public string Icon {get;set;}


		/// <summary>
		/// 【颜色】
		/// </summary>
		public string Color {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		public string Title {get;set;}


		/// <summary>
		/// 【是否站外链接】
		/// </summary>
		public byte? IsOutLink {get;set;}


		/// <summary>
		/// 【链接】
		/// </summary>
		public string Url {get;set;}


		/// <summary>
		/// 【内容】
		/// </summary>
		public string Content {get;set;}


		/// <summary>
		/// 【排序号】
		/// </summary>
		public int? Sort {get;set;}


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
