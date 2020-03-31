using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【订单】
	/// </summary>
	public partial class ordersModel
	{
		/// <summary>
		/// 【订单ID】
		/// </summary>
		[JsonProperty("订单ID")]
		public long? OrderID {get;set;}


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
		/// 【订单号】
		/// </summary>
		[JsonProperty("订单号")]
		public string OrderNo {get;set;}


		/// <summary>
		/// 【订单状态】[0，未支付
		///             1，已支付
		///             2，已取消
		///             3，支付失败]
		/// </summary>
		[JsonProperty("订单状态")]
		public OrderStatusEnum? OrderStatus {get;set;}


		/// <summary>
		/// 【支付类型】[0，微信
		///             1，支付宝
		///             2，其他]
		/// </summary>
		[JsonProperty("支付类型")]
		public BillModelEnum? BillModel {get;set;}


		/// <summary>
		/// 【总金额】
		/// </summary>
		[JsonProperty("总金额")]
		public decimal? TotalFee {get;set;}


		/// <summary>
		/// 【总数量】
		/// </summary>
		[JsonProperty("总数量")]
		public int? TotalQuantity {get;set;}


		/// <summary>
		/// 【订单类型】[0，预约挂号
		///             1，诊间支付
		///             2，咨询]
		/// </summary>
		[JsonProperty("订单类型")]
		public OrderTypeEnum? OrderType {get;set;}


		/// <summary>
		/// 【来源ID】
		/// </summary>
		[JsonProperty("来源ID")]
		public long? SourceID {get;set;}


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
		/// 【His数据】
		/// </summary>
		[JsonProperty("His数据")]
		public string HisData {get;set;}


		/// <summary>
		/// 【MD5数据加密】
		/// </summary>
		[JsonProperty("MD5数据加密")]
		public string MD5Valid {get;set;}


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
		/// 【订单明细】
		/// </summary>
		public virtual ICollection<OrderItemsJsonModel> OrderItems {get;set;}


		/// <summary>
		/// 【退款记录】
		/// </summary>
		public virtual ICollection<refundordersJsonModel> refundorders {get;set;}


		/// <summary>
		/// 【交易记录】
		/// </summary>
		public virtual ICollection<TransactionsJsonModel> Transactions {get;set;}



	}
}
