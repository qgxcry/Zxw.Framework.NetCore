using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【订单明细】
	/// </summary>
	public partial class OrderItemsDto
	{
		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		public long OrderItemID {get;set;}


		/// <summary>
		/// 【订单ID】
		/// </summary>
		public long? OrderID {get;set;}
		/// <summary>
		/// 【订单ID】
		/// </summary>
		public virtual OrdersDto Orders {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		public string ProductName {get;set;}


		/// <summary>
		/// 【价格】
		/// </summary>
		public decimal? Price {get;set;}


		/// <summary>
		/// 【数量】
		/// </summary>
		public int? Quantity {get;set;}


		/// <summary>
		/// 【单据号】
		/// </summary>
		public string BillNo {get;set;}


		/// <summary>
		/// 【来源ID】
		/// </summary>
		public long? SourceID {get;set;}


		/// <summary>
		/// 【His数据】
		/// </summary>
		public string HisItemData {get;set;}


		/// <summary>
		/// 【是否退款】
		/// </summary>
		public byte? IsRefund {get;set;}


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
		/// 【退款明细】
		/// </summary>
		public virtual ICollection<RefundOrderItemsDto> RefundOrderItems {get;set;}


		/// <summary>
		/// 【交易明细】
		/// </summary>
		public virtual ICollection<TransactionItemsDto> TransactionItems {get;set;}



	}
}
