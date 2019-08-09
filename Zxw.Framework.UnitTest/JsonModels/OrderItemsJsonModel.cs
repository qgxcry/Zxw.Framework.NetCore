using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【订单明细】
	/// </summary>
	public partial class OrderItemsModel
	{
		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		[JsonProperty("订单明细ID")]
		public long OrderItemID {get;set;}


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
		/// 【名称】
		/// </summary>
		[JsonProperty("名称")]
		public string ProductName {get;set;}


		/// <summary>
		/// 【价格】
		/// </summary>
		[JsonProperty("价格")]
		public decimal? Price {get;set;}


		/// <summary>
		/// 【数量】
		/// </summary>
		[JsonProperty("数量")]
		public int? Quantity {get;set;}


		/// <summary>
		/// 【单据号】
		/// </summary>
		[JsonProperty("单据号")]
		public string BillNo {get;set;}


		/// <summary>
		/// 【来源ID】
		/// </summary>
		[JsonProperty("来源ID")]
		public long? SourceID {get;set;}


		/// <summary>
		/// 【His数据】
		/// </summary>
		[JsonProperty("His数据")]
		public string HisItemData {get;set;}


		/// <summary>
		/// 【是否退款】
		/// </summary>
		[JsonProperty("是否退款")]
		public byte? IsRefund {get;set;}


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
		/// 【交易明细】
		/// </summary>
		public virtual ICollection<TransactionItemsJsonModel> TransactionItems {get;set;}



	}
}
