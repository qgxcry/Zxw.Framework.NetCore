using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【检查项目】
	/// </summary>
	public class CheckItemsModel
	{
		/// <summary>
		/// 【检查项目ID】
		/// </summary>
		[JsonProperty("检查项目ID")]
		public int CheckItemID {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		[JsonProperty("医院ID")]
		public int? HospitalID {get;set;}


		/// <summary>
		/// 【项目编号】
		/// </summary>
		[JsonProperty("项目编号")]
		public string CINO {get;set;}


		/// <summary>
		/// 【项目名称】
		/// </summary>
		[JsonProperty("项目名称")]
		public string CIName {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}


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
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}



	}
}
