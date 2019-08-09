using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【交易明细】
	/// </summary>
	public partial class TransactionItemsDto
	{
		/// <summary>
		/// 【交易明细ID】
		/// </summary>
		public long TransactionItemID {get;set;}


		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		public long? OrderItemID {get;set;}
		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		public virtual OrderItemsDto OrderItems {get;set;}


		/// <summary>
		/// 【退款明细ID】
		/// </summary>
		public long? RefundOrderItemID {get;set;}
		/// <summary>
		/// 【退款明细ID】
		/// </summary>
		public virtual RefundOrderItemsDto RefundOrderItems {get;set;}


		/// <summary>
		/// 【交易ID】
		/// </summary>
		public long? TransactionID {get;set;}
		/// <summary>
		/// 【交易ID】
		/// </summary>
		public virtual TransactionsDto Transactions {get;set;}


		/// <summary>
		/// 【交易金额】
		/// </summary>
		public decimal? TransFee {get;set;}


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
