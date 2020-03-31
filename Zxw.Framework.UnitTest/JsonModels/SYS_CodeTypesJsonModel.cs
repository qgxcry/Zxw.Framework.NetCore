using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【代码类别】
	/// </summary>
	public partial class SYS_CodeTypesModel
	{
		/// <summary>
		/// 【代码类别ID】
		/// </summary>
		[JsonProperty("代码类别ID")]
		public int? CodeTypeID {get;set;}


		/// <summary>
		/// 【类别名称】
		/// </summary>
		[JsonProperty("类别名称")]
		public string CodeNameType {get;set;}


		/// <summary>
		/// 【类别值】
		/// </summary>
		[JsonProperty("类别值")]
		public byte? CodeTypeVal {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【修改时间】
		/// </summary>
		[JsonProperty("修改时间")]
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


		/// <summary>
		/// 【代码表】
		/// </summary>
		public virtual ICollection<SYS_CodesJsonModel> SYS_Codes {get;set;}



	}
}
