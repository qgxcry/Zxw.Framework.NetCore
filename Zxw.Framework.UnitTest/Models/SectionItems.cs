using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【栏目配置项】
	/// </summary>
	[Table("SectionItems")]
	public partial class SectionItems:BaseEntity
	{
		/// <summary>
		/// 【栏目配置项ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  int SectionItemID {get;set;}


		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		public int? SectionID {get;set;}
		/// <summary>
		/// 【栏目配置ID】
		/// </summary>
		[ForeignKey("SectionID")]
		public virtual Sections Sections {get;set;}


		/// <summary>
		/// 【图标】
		/// </summary>
		[MaxLength(50)]
		public string Icon {get;set;}


		/// <summary>
		/// 【颜色】
		/// </summary>
		[MaxLength(50)]
		public string Color {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[MaxLength(50)]
		public string Title {get;set;}


		/// <summary>
		/// 【是否站外链接】
		/// </summary>
		public byte? IsOutLink {get;set;}


		/// <summary>
		/// 【链接】
		/// </summary>
		[MaxLength(100)]
		public string Url {get;set;}


		/// <summary>
		/// 【内容】
		/// </summary>
		[MaxLength(65535)]
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
