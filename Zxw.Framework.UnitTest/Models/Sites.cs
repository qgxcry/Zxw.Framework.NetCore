using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【站点】
	/// </summary>
	[Table("Sites")]
	public partial class Sites:BaseEntity
	{
		/// <summary>
		/// 【站点ID】
		/// </summary>
		[Key]
		public  string Id {get;set;}


		/// <summary>
		/// 【Site】
		/// </summary>
		[MaxLength(50)]
		public string SiteName {get;set;}


		/// <summary>
		/// 【Code】
		/// </summary>
		[MaxLength(50)]
		public string SiteCode {get;set;}


		/// <summary>
		/// 【Url】
		/// </summary>
		[MaxLength(50)]
		public string SiteUrl {get;set;}


		/// <summary>
		/// 【CreateTime】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【UpdateTime】
		/// </summary>
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【IsDeleted】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【IsEnabled】
		/// </summary>
		public byte? IsEnabled {get;set;}



	}
}
