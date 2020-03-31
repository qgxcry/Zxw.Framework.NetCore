using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【站点】
	/// </summary>
	public partial class SitesDto
	{
		/// <summary>
		/// 【站点ID】
		/// </summary>
		public string Id {get;set;}


		/// <summary>
		/// 【Site】
		/// </summary>
		public string SiteName {get;set;}


		/// <summary>
		/// 【Code】
		/// </summary>
		public string SiteCode {get;set;}


		/// <summary>
		/// 【Url】
		/// </summary>
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
