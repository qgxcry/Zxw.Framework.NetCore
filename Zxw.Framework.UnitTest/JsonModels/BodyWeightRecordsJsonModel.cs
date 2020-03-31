using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【体重管理】
	/// </summary>
	public partial class BodyWeightRecordsModel
	{
		/// <summary>
		/// 【体重记录ID】
		/// </summary>
		[JsonProperty("体重记录ID")]
		public long? BodyWeightRecordID {get;set;}


		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		[JsonProperty("孕期记录ID")]
		public long? GestationRecordID {get;set;}
		/// <summary>
		/// 【孕期记录ID】
		/// </summary>
		public virtual GestationRecordsJsonModel GestationRecords {get;set;}


		/// <summary>
		/// 【孕期体重增长类型ID】
		/// </summary>
		[JsonProperty("孕期体重增长类型ID")]
		public long? BodyWeightTypeID {get;set;}
		/// <summary>
		/// 【孕期体重增长类型ID】
		/// </summary>
		public virtual BodyWeightLimitTypeJsonModel BodyWeightLimitType {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}


		/// <summary>
		/// 【孕周】
		/// </summary>
		[JsonProperty("孕周")]
		public int? Week {get;set;}


		/// <summary>
		/// 【体重类型】[0，体重过轻
		///             1，体重正常
		///             2，体重超重
		///             3，体重肥胖]
		/// </summary>
		[JsonProperty("体重类型")]
		public BodyWeightTypeEnum? BodyWeightType {get;set;}


		/// <summary>
		/// 【体重】
		/// </summary>
		[JsonProperty("体重")]
		public decimal? Weight {get;set;}


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
