using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【微信二维码】
	/// </summary>
	public partial class QrCodeModel
	{
		/// <summary>
		/// 【微信二维码ID】
		/// </summary>
		[JsonProperty("微信二维码ID")]
		public long? QrCodeID {get;set;}


		/// <summary>
		/// 【二维码有效期】
		/// </summary>
		[JsonProperty("二维码有效期")]
		public int? ExpireSeconds {get;set;}


		/// <summary>
		/// 【二维码类型】[10，QR_SCENE
		///             20，QR_STR_SCENE
		///             30，QR_LIMIT_SCENE
		///             40，QR_LIMIT_STR_SCENE
		///             ]
		/// </summary>
		[JsonProperty("二维码类型")]
		public ActionNameEnum? ActionName {get;set;}


		/// <summary>
		/// 【场景值ID整数】
		/// </summary>
		[JsonProperty("场景值ID整数")]
		public int? SceneId {get;set;}


		/// <summary>
		/// 【场景值ID字符串】
		/// </summary>
		[JsonProperty("场景值ID字符串")]
		public string SceneStr {get;set;}


		/// <summary>
		/// 【二维码Url地址】
		/// </summary>
		[JsonProperty("二维码Url地址")]
		public string Url {get;set;}


		/// <summary>
		/// 【获取二维码Ticke】
		/// </summary>
		[JsonProperty("获取二维码Ticke")]
		public string Ticket {get;set;}


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
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【事件推送】
		/// </summary>
		public virtual ICollection<ReceiveEventJsonModel> ReceiveEvent {get;set;}



	}
}
