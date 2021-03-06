using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【个人过敏源】
	/// </summary>
	public partial class PersonAllergensModel
	{
		/// <summary>
		/// 【ID】
		/// </summary>
		[JsonProperty("ID")]
		public long PersonAllergenID {get;set;}


		/// <summary>
		/// 【过敏源ID】
		/// </summary>
		[JsonProperty("过敏源ID")]
		public int? AllergenID {get;set;}
		/// <summary>
		/// 【过敏源ID】
		/// </summary>
		public virtual AllergensJsonModel Allergens {get;set;}


		/// <summary>
		/// 【其他过敏源】
		/// </summary>
		[JsonProperty("其他过敏源")]
		public string OtherAllergen {get;set;}


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
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}



	}
}
