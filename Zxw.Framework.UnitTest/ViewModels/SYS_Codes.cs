using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【代码表】
	/// </summary>
	public class SYS_CodesViewModel
	{
		/// <summary>
		/// 【代码ID】
		/// </summary>
		[Required]
		public int CodeID {get;set;}


		/// <summary>
		/// 【代码类别ID】
		/// </summary>
		public int? CodeTypeID {get;set;}


		/// <summary>
		/// 【编码】
		/// </summary>
		[MaxLength(50)]
		public string CodeVal {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[MaxLength(50)]
		public string CodeName {get;set;}


		/// <summary>
		/// 【简拼】
		/// </summary>
		[MaxLength(50)]
		public string JianPin {get;set;}


		/// <summary>
		/// 【全拼】
		/// </summary>
		[MaxLength(100)]
		public string QuanPin {get;set;}


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


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}



	}
}
