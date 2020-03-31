using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Web.Models
{
	/// <summary>
	/// 【退款明细】
	/// </summary>
	public partial class RefundOrderItemsViewModel
	{
		/// <summary>
		/// 【退款明细ID】
		/// </summary>
		public long? RefundOrderItemID {get;set;}


		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		public long? RefundOrderID {get;set;}
		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		public virtual RefundOrdersViewModel RefundOrders {get;set;}


		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		public long? OrderItemID {get;set;}
		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		public virtual OrderItemsViewModel OrderItems {get;set;}


		/// <summary>
		/// 【退款金额】
		/// </summary>
		public decimal? RefundFee {get;set;}


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
		/// 【交易明细】
		/// </summary>
		public virtual ICollection<TransactionItemsViewModel> TransactionItems {get;set;}



	}
}
