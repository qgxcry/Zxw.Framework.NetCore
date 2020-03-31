using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【退款记录】
	/// </summary>
	public partial class refundordersModel
	{
		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		[JsonProperty("退款订单ID")]
		public long? RefundOrderID {get;set;}


		/// <summary>
		/// 【订单ID】
		/// </summary>
		[JsonProperty("订单ID")]
		public long? OrderID {get;set;}
		/// <summary>
		/// 【订单ID】
		/// </summary>
		public virtual OrdersJsonModel Orders {get;set;}


		/// <summary>
		/// 【站点ID】
		/// </summary>
		[JsonProperty("站点ID")]
		public int? SiteID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}


		/// <summary>
		/// 【档案ID】
		/// </summary>
		[JsonProperty("档案ID")]
		public long? ArchiveID {get;set;}


		/// <summary>
		/// 【退款订单编号】
		/// </summary>
		[JsonProperty("退款订单编号")]
		public string RefundOrderNo {get;set;}


		/// <summary>
		/// 【退款金额】
		/// </summary>
		[JsonProperty("退款金额")]
		public decimal? RefundFee {get;set;}


		/// <summary>
		/// 【退款类型】[0，全额
		///             1，部分]
		/// </summary>
		[JsonProperty("退款类型")]
		public RefundTypeEnum? RefundType {get;set;}


		/// <summary>
		/// 【退款状态】
		/// </summary>
		[JsonProperty("退款状态")]
		public byte? RefundStatus {get;set;}


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


		/// <summary>
		/// 【退款明细】
		/// </summary>
		public virtual ICollection<RefundOrderItemsJsonModel> RefundOrderItems {get;set;}


		/// <summary>
		/// 【交易记录】
		/// </summary>
		public virtual ICollection<TransactionsJsonModel> Transactions {get;set;}



	}
}
