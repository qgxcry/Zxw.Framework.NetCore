using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【订单】
	/// </summary>
	[Table("orders")]
	public partial class orders:BaseEntity
	{
		/// <summary>
		/// 【订单ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  long OrderID {get;set;}


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
		/// 【订单号】
		/// </summary>
		[MaxLength(50)]
		public string OrderNo {get;set;}


		/// <summary>
		/// 【订单状态】[0，未支付
		///             1，已支付
		///             2，已取消
		///             3，支付失败]
		/// </summary>
		public OrderStatusEnum? OrderStatus {get;set;}


		/// <summary>
		/// 【支付类型】[0，微信
		///             1，支付宝
		///             2，其他]
		/// </summary>
		public BillModelEnum? BillModel {get;set;}


		/// <summary>
		/// 【总金额】
		/// </summary>
		public decimal? TotalFee {get;set;}


		/// <summary>
		/// 【总数量】
		/// </summary>
		public int? TotalQuantity {get;set;}


		/// <summary>
		/// 【订单类型】[0，预约挂号
		///             1，诊间支付
		///             2，咨询]
		/// </summary>
		public OrderTypeEnum? OrderType {get;set;}


		/// <summary>
		/// 【来源ID】
		/// </summary>
		public long? SourceID {get;set;}


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
		/// 【His数据】
		/// </summary>
		[MaxLength(65535)]
		public string HisData {get;set;}


		/// <summary>
		/// 【MD5数据加密】
		/// </summary>
		[MaxLength(50)]
		public string MD5Valid {get;set;}


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
		/// 【订单明细】
		/// </summary>
		public virtual ICollection<OrderItems> OrderItems {get;set;}


		/// <summary>
		/// 【退款记录】
		/// </summary>
		public virtual ICollection<refundorders> refundorders {get;set;}


		/// <summary>
		/// 【交易记录】
		/// </summary>
		public virtual ICollection<Transactions> Transactions {get;set;}



	}
}
