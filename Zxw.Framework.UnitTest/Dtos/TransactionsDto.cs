using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【交易记录】
	/// </summary>
	public partial class TransactionsDto
	{
		/// <summary>
		/// 【交易ID】
		/// </summary>
		public long? TransactionID {get;set;}


		/// <summary>
		/// 【订单ID】
		/// </summary>
		public long? OrderID {get;set;}
		/// <summary>
		/// 【订单ID】
		/// </summary>
		public virtual OrdersDto Orders {get;set;}


		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		public long? RefundOrderID {get;set;}
		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		public virtual RefundOrdersDto RefundOrders {get;set;}


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
		/// 【交易金额】
		/// </summary>
		public decimal? TransFee {get;set;}


		/// <summary>
		/// 【交易编号】
		/// </summary>
		public string TransNo {get;set;}


		/// <summary>
		/// 【交易类型】
		/// </summary>
		public byte? TransType {get;set;}


		/// <summary>
		/// 【微信交易号】
		/// </summary>
		public string WxTransNo {get;set;}


		/// <summary>
		/// 【交易状态】[0，失败
		/// 10，成功
		/// 20，订单不存在
		/// 30，金额不匹配]
		/// </summary>
		public TransStatusEnum? TransStatus {get;set;}


		/// <summary>
		/// 【微信商户ID】
		/// </summary>
		public string WxMerchantID {get;set;}


		/// <summary>
		/// 【微信子商户ID】
		/// </summary>
		public string WxSubMerchantD {get;set;}


		/// <summary>
		/// 【微信OpenId】
		/// </summary>
		public string WxOpenId {get;set;}


		/// <summary>
		/// 【交易说明】HIS对账使用
		/// </summary>
		public string BusinessExplain {get;set;}


		/// <summary>
		/// 【微信返回数据】
		/// </summary>
		public string WxResult {get;set;}


		/// <summary>
		/// 【MD5数据加密】
		/// </summary>
		public string MD5Valid {get;set;}


		/// <summary>
		/// 【是否退款】
		/// </summary>
		public byte? IsRefund {get;set;}


		/// <summary>
		/// 【退款类型】[0，全额
		///             1，部分]
		/// </summary>
		public RefundTypeEnum? RefundType {get;set;}


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
		public virtual ICollection<TransactionItemsDto> TransactionItems {get;set;}



	}
}
