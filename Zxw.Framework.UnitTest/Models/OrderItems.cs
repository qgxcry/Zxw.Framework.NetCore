using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【订单明细】
	/// </summary>
	[Table("OrderItems")]
	public partial class OrderItems:BaseEntity
	{
		/// <summary>
		/// 【订单明细ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  long OrderItemID {get;set;}


		/// <summary>
		/// 【订单ID】
		/// </summary>
		public long? OrderID {get;set;}
		/// <summary>
		/// 【订单ID】
		/// </summary>
		[ForeignKey("OrderID")]
		public virtual Orders Orders {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[MaxLength(50)]
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
		[MaxLength(50)]
		public string BillNo {get;set;}


		/// <summary>
		/// 【来源ID】
		/// </summary>
		public long? SourceID {get;set;}


		/// <summary>
		/// 【His数据】
		/// </summary>
		[MaxLength(65535)]
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
		public virtual ICollection<RefundOrderItems> RefundOrderItems {get;set;}


		/// <summary>
		/// 【交易明细】
		/// </summary>
		public virtual ICollection<TransactionItems> TransactionItems {get;set;}



	}
}
