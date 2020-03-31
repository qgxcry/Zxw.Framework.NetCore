using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Web.Models
{
	/// <summary>
	/// 【栏目配置】
	/// </summary>
	public partial class SectionsViewModel
	{
		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		public int? SectionID {get;set;}


		/// <summary>
		/// 【公众号站点ID】
		/// </summary>
		public int? SiteID {get;set;}
		/// <summary>
		/// 【公众号站点ID】
		/// </summary>
		public virtual SitesViewModel Sites {get;set;}


		/// <summary>
		/// 【栏目标题】
		/// </summary>
		[MaxLength(50)]
		public string Title {get;set;}


		/// <summary>
		/// 【栏目类型】0，图标
		///             1，色块
		///             2，列表
		/// </summary>
		public byte? Type {get;set;}


		/// <summary>
		/// 【是否显示标题】
		/// </summary>
		public byte? IsShowTitle {get;set;}


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


		/// <summary>
		/// 【栏目配置项】
		/// </summary>
		public virtual ICollection<SectionItemsViewModel> SectionItems {get;set;}



	}
}
