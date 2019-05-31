using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【微信二维码】
	/// </summary>
	public class QrCodeViewModel
	{
		/// <summary>
		/// 【微信二维码ID】
		/// </summary>
		[Required]
		public long QrCodeID {get;set;}


		/// <summary>
		/// 【Attribute_2】
		/// </summary>
		public int? ExpireSeconds {get;set;}


		/// <summary>
		/// 【Attribute_3】
		/// </summary>
		[MaxLength(50)]
		public string ActionName {get;set;}


		/// <summary>
		/// 【场景值ID2】
		/// </summary>
		public int? SceneId {get;set;}


		/// <summary>
		/// 【场景值ID】
		/// </summary>
		[MaxLength(50)]
		public string SceneStr {get;set;}


		/// <summary>
		/// 【二维码Url地址】
		/// </summary>
		[MaxLength(50)]
		public string Url {get;set;}


		/// <summary>
		/// 【Attribute_7】
		/// </summary>
		[MaxLength(50)]
		public string Ticket {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【事件推送】
		/// </summary>
		public virtual ICollection<ReceiveEvent> ReceiveEvent {get;set;}



	}
}
