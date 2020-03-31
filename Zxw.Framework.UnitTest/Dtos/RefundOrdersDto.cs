using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【退款记录】
	/// </summary>
	public partial class refundordersDto
	{
		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		public long? RefundOrderID {get;set;}


		/// <summary>
		/// 【订单ID】
		/// </summary>
		public long? OrderID {get;set;}
		/// <summary>
		/// 【订单ID】
		/// </summary>
		public virtual OrdersDto Orders {get;set;}


		/// <summary>
		/// 【站点ID】
		/// </summary>
		public int? SiteID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【档案ID】
		/// </summary>
		public long? ArchiveID {get;set;}


		/// <summary>
		/// 【退款订单编号】
		/// </summary>
		public string RefundOrderNo {get;set;}


		/// <summary>
		/// 【退款金额】
		/// </summary>
		public decimal? RefundFee {get;set;}


		/// <summary>
		/// 【退款类型】[0，全额
		///             1，部分]
		/// </summary>
		public RefundTypeEnum? RefundType {get;set;}


		/// <summary>
		/// 【退款状态】
		/// </summary>
		public byte? RefundStatus {get;set;}


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
		/// 【交易记录】
		/// </summary>
		public virtual ICollection<TransactionsDto> Transactions {get;set;}



	}
}
