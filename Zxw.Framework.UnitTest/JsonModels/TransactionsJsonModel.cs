using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【交易记录】
	/// </summary>
	public partial class TransactionsModel
	{
		/// <summary>
		/// 【交易ID】
		/// </summary>
		[JsonProperty("交易ID")]
		public long TransactionID {get;set;}


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
		/// 【退款订单ID】
		/// </summary>
		[JsonProperty("退款订单ID")]
		public long? RefundOrderID {get;set;}
		/// <summary>
		/// 【退款订单ID】
		/// </summary>
		public virtual RefundOrdersJsonModel RefundOrders {get;set;}


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
		/// 【交易金额】
		/// </summary>
		[JsonProperty("交易金额")]
		public decimal? TransFee {get;set;}


		/// <summary>
		/// 【交易编号】
		/// </summary>
		[JsonProperty("交易编号")]
		public string TransNo {get;set;}


		/// <summary>
		/// 【交易类型】
		/// </summary>
		[JsonProperty("交易类型")]
		public byte? TransType {get;set;}


		/// <summary>
		/// 【微信交易号】
		/// </summary>
		[JsonProperty("微信交易号")]
		public string WxTransNo {get;set;}


		/// <summary>
		/// 【交易状态】[0，失败
		/// 10，成功
		/// 20，订单不存在
		/// 30，金额不匹配]
		/// </summary>
		[JsonProperty("交易状态")]
		public TransStatusEnum? TransStatus {get;set;}


		/// <summary>
		/// 【微信商户ID】
		/// </summary>
		[JsonProperty("微信商户ID")]
		public string WxMerchantID {get;set;}


		/// <summary>
		/// 【微信子商户ID】
		/// </summary>
		[JsonProperty("微信子商户ID")]
		public string WxSubMerchantD {get;set;}


		/// <summary>
		/// 【微信OpenId】
		/// </summary>
		[JsonProperty("微信OpenId")]
		public string WxOpenId {get;set;}


		/// <summary>
		/// 【交易说明】HIS对账使用
		/// </summary>
		[JsonProperty("交易说明")]
		public string BusinessExplain {get;set;}


		/// <summary>
		/// 【微信返回数据】
		/// </summary>
		[JsonProperty("微信返回数据")]
		public string WxResult {get;set;}


		/// <summary>
		/// 【MD5数据加密】
		/// </summary>
		[JsonProperty("MD5数据加密")]
		public string MD5Valid {get;set;}


		/// <summary>
		/// 【是否退款】
		/// </summary>
		[JsonProperty("是否退款")]
		public byte? IsRefund {get;set;}


		/// <summary>
		/// 【退款类型】[0，全额
		///             1，部分]
		/// </summary>
		[JsonProperty("退款类型")]
		public RefundTypeEnum? RefundType {get;set;}


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
