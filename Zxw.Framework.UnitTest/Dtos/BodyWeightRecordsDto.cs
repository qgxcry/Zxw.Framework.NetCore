using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【体重管理】
	/// </summary>
	public partial class BodyWeightRecordsDto
	{
		/// <summary>
		/// 【体重记录ID】
		/// </summary>
		public long? BodyWeightRecordID {get;set;}


		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public long? GestationRecordID {get;set;}
		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public virtual GestationRecordsDto GestationRecords {get;set;}


		/// <summary>
		/// 【孕期体重增长类型ID】
		/// </summary>
		public long? BodyWeightTypeID {get;set;}
		/// <summary>
		/// 【孕期体重增长类型ID】
		/// </summary>
		public virtual BodyWeightLimitTypeDto BodyWeightLimitType {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【孕周】
		/// </summary>
		public int? Week {get;set;}


		/// <summary>
		/// 【体重类型】[0，体重过轻
		///             1，体重正常
		///             2，体重超重
		///             3，体重肥胖]
		/// </summary>
		public BodyWeightTypeEnum? BodyWeightType {get;set;}


		/// <summary>
		/// 【体重】
		/// </summary>
		public decimal? Weight {get;set;}


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
