using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【代码表】
	/// </summary>
	public partial class SYS_CodesModel
	{
		/// <summary>
		/// 【代码ID】
		/// </summary>
		[JsonProperty("代码ID")]
		public int? CodeID {get;set;}


		/// <summary>
		/// 【代码类别ID】
		/// </summary>
		[JsonProperty("代码类别ID")]
		public int? CodeTypeID {get;set;}
		/// <summary>
		/// 【代码类别ID】
		/// </summary>
		public virtual SYS_CodeTypesJsonModel SYS_CodeTypes {get;set;}


		/// <summary>
		/// 【编码】
		/// </summary>
		[JsonProperty("编码")]
		public string CodeVal {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[JsonProperty("名称")]
		public string CodeName {get;set;}


		/// <summary>
		/// 【简拼】
		/// </summary>
		[JsonProperty("简拼")]
		public string JianPin {get;set;}


		/// <summary>
		/// 【全拼】
		/// </summary>
		[JsonProperty("全拼")]
		public string QuanPin {get;set;}


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


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}



	}
}
