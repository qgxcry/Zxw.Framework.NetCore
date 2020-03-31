using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【胎动记录】
	/// </summary>
	[Table("FetalRecords")]
	public partial class FetalRecords:BaseEntity
	{
		/// <summary>
		/// 【胎动记录ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  long FetalRecordID {get;set;}


		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public long? GestationRecordID {get;set;}
		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		[ForeignKey("GestationRecordID")]
		public virtual GestationRecords GestationRecords {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【孕周】
		/// </summary>
		public int? Week {get;set;}


		/// <summary>
		/// 【孕天】
		/// </summary>
		public int? Day {get;set;}


		/// <summary>
		/// 【早】
		/// </summary>
		public int? Morning {get;set;}


		/// <summary>
		/// 【中】
		/// </summary>
		public int? Noon {get;set;}


		/// <summary>
		/// 【晚】
		/// </summary>
		public int? Night {get;set;}


		/// <summary>
		/// 【12小时胎动总数】
		/// </summary>
		public int? Total {get;set;}


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
