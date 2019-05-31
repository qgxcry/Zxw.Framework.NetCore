using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【个人过敏源】
	/// </summary>
	public partial class PersonAllergensViewModel
	{
		/// <summary>
		/// 【ID】
		/// </summary>
		[Required]
		public long PersonAllergenID {get;set;}


		/// <summary>
		/// 【过敏源ID】
		/// </summary>
		public int? AllergenID {get;set;}
		/// <summary>
		/// 【过敏源ID】
		/// </summary>
		public virtual AllergensViewModel Allergens {get;set;}


		/// <summary>
		/// 【其他过敏源】
		/// </summary>
		[MaxLength(100)]
		public string OtherAllergen {get;set;}


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
