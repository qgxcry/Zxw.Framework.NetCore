using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【高危因素】
	/// </summary>
	[Table("HighRiskFactor")]
	public partial class HighRiskFactor:BaseEntity
	{
		/// <summary>
		/// 【高危因素ID】
		/// </summary>
		[Key]
		public  long HighRiskFactorID {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[MaxLength(200)]
		public string Name {get;set;}


		/// <summary>
		/// 【简码】
		/// </summary>
		[MaxLength(100)]
		public string SortCode {get;set;}


		/// <summary>
		/// 【层级代码】
		/// </summary>
		[MaxLength(50)]
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
		[MaxLength(2000)]
		public string Effect {get;set;}


		/// <summary>
		/// 【干预指导方案】
		/// </summary>
		[MaxLength(2000)]
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
		public virtual ICollection<HighRiskRecords> HighRiskRecords {get;set;}



	}
}
