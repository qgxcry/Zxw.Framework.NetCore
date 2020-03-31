using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【微信二维码】
	/// </summary>
	[Table("QrCode")]
	public partial class QrCode:BaseEntity
	{
		/// <summary>
		/// 【微信二维码ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  long QrCodeID {get;set;}


		/// <summary>
		/// 【二维码有效期】
		/// </summary>
		public int? ExpireSeconds {get;set;}


		/// <summary>
		/// 【二维码类型】[10，QR_SCENE
		///             20，QR_STR_SCENE
		///             30，QR_LIMIT_SCENE
		///             40，QR_LIMIT_STR_SCENE
		///             ]
		/// </summary>
		public ActionNameEnum? ActionName {get;set;}


		/// <summary>
		/// 【场景值ID整数】
		/// </summary>
		public int? SceneId {get;set;}


		/// <summary>
		/// 【场景值ID字符串】
		/// </summary>
		[MaxLength(50)]
		public string SceneStr {get;set;}


		/// <summary>
		/// 【二维码Url地址】
		/// </summary>
		[MaxLength(50)]
		public string Url {get;set;}


		/// <summary>
		/// 【获取二维码Ticke】
		/// </summary>
		[MaxLength(100)]
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
