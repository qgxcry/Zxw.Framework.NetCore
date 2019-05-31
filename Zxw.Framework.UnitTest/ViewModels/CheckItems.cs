using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【检查项目】
	/// </summary>
	public class CheckItemsViewModel
	{
		/// <summary>
		/// 【检查项目ID】
		/// </summary>
		[Required]
		public int CheckItemID {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		public int? HospitalID {get;set;}


		/// <summary>
		/// 【项目编号】
		/// </summary>
		[MaxLength(50)]
		public string CINO {get;set;}


		/// <summary>
		/// 【项目名称】
		/// </summary>
		[MaxLength(50)]
		public string CIName {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}



	}
}
