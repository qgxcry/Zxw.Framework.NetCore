using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【交易明细】
	/// </summary>
	public partial class TransactionItemsModel
	{
		/// <summary>
		/// 【交易明细ID】
		/// </summary>
		[JsonProperty("交易明细ID")]
		public long TransactionItemID {get;set;}


		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		[JsonProperty("订单明细ID")]
		public long? OrderItemID {get;set;}
		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		public virtual OrderItemsJsonModel OrderItems {get;set;}


		/// <summary>
		/// 【退款明细ID】
		/// </summary>
		[JsonProperty("退款明细ID")]
		public long? RefundOrderItemID {get;set;}
		/// <summary>
		/// 【退款明细ID】
		/// </summary>
		public virtual RefundOrderItemsJsonModel RefundOrderItems {get;set;}


		/// <summary>
		/// 【交易ID】
		/// </summary>
		[JsonProperty("交易ID")]
		public long? TransactionID {get;set;}
		/// <summary>
		/// 【交易ID】
		/// </summary>
		public virtual TransactionsJsonModel Transactions {get;set;}


		/// <summary>
		/// 【交易金额】
		/// </summary>
		[JsonProperty("交易金额")]
		public decimal? TransFee {get;set;}


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
