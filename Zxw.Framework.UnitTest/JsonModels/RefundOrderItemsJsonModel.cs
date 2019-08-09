using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【退款明细】
	/// </summary>
	public partial class RefundOrderItemsModel
	{
		/// <summary>
		/// 【退款明细ID】
		/// </summary>
		[JsonProperty("退款明细ID")]
		public long RefundOrderItemID {get;set;}


		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		[JsonProperty("退款订单ID")]
		public long? RefundOrderID {get;set;}
		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		public virtual RefundOrdersJsonModel RefundOrders {get;set;}


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
		/// 【退款金额】
		/// </summary>
		[JsonProperty("退款金额")]
		public decimal? RefundFee {get;set;}


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
		/// 【交易明细】
		/// </summary>
		public virtual ICollection<TransactionItemsJsonModel> TransactionItems {get;set;}



	}
}
