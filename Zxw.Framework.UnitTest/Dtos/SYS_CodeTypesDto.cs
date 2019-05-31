using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【代码类别】
	/// </summary>
	public partial class SYS_CodeTypesDto
	{
		/// <summary>
		/// 【代码类别ID】
		/// </summary>
		public int CodeTypeID {get;set;}


		/// <summary>
		/// 【类别名称】
		/// </summary>
		public string CodeNameType {get;set;}


		/// <summary>
		/// 【类别值】
		/// </summary>
		public byte? CodeTypeVal {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【修改时间】
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


		/// <summary>
		/// 【代码表】
		/// </summary>
		public virtual ICollection<SYS_CodesDto> SYS_Codes {get;set;}



	}
}
