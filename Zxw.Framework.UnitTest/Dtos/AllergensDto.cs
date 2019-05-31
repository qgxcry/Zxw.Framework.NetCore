using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【过敏源】
	/// </summary>
	public partial class AllergensDto
	{
		/// <summary>
		/// 【过敏源ID】
		/// </summary>
		public int AllergenID {get;set;}


		/// <summary>
		/// 【过敏源名称】
		/// </summary>
		public string AllergenName {get;set;}


		/// <summary>
		/// 【编码】
		/// </summary>
		public string CodeNo {get;set;}


		/// <summary>
		/// 【其他】0，常见过敏源
		///             1，其他过敏源
		/// </summary>
		public byte? IsOther {get;set;}


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


		/// <summary>
		/// 【个人过敏源】
		/// </summary>
		public virtual ICollection<PersonAllergensDto> PersonAllergens {get;set;}



	}
}
