using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【高危因素】
	/// </summary>
	public partial class HighRiskFactorDto
	{
		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		public long HighRiskFactorID {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		public string Name {get;set;}


		/// <summary>
		/// 【简码】
		/// </summary>
		public string SortCode {get;set;}


		/// <summary>
		/// 【层级代码】
		/// </summary>
		public string IndexCode {get;set;}


		/// <summary>
		/// 【上级ID】
		/// </summary>
		public long? ParentID {get;set;}


		/// <summary>
		/// 【是否是子节点】
		/// </summary>
		public byte? IsChildren {get;set;}


		/// <summary>
		/// 【排序】
		/// </summary>
		public int? Sort {get;set;}


		/// <summary>
		/// 【产生的影响】
		/// </summary>
		public string Effect {get;set;}


		/// <summary>
		/// 【干预指导方案】
		/// </summary>
		public string TreatPlan {get;set;}


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
		/// 【高危因素记录】
		/// </summary>
		public virtual ICollection<HighRiskRecordsDto> HighRiskRecords {get;set;}



	}
}
