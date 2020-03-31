using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【事件推送】
	/// </summary>
	public partial class ReceiveEventModel
	{
		/// <summary>
		/// 【事件推送ID】
		/// </summary>
		[JsonProperty("事件推送ID")]
		public long? ReceiveEventID {get;set;}


		/// <summary>
		/// 【微信二维码ID】
		/// </summary>
		[JsonProperty("微信二维码ID")]
		public long? QrCodeID {get;set;}
		/// <summary>
		/// 【微信二维码ID】
		/// </summary>
		public virtual QrCodeJsonModel QrCode {get;set;}


		/// <summary>
		/// 【开发者微信号】
		/// </summary>
		[JsonProperty("开发者微信号")]
		public string ToUserName {get;set;}


		/// <summary>
		/// 【发送方OpenID】
		/// </summary>
		[JsonProperty("发送方OpenID")]
		public string FromUserName {get;set;}


		/// <summary>
		/// 【消息创建时间】
		/// </summary>
		[JsonProperty("消息创建时间")]
		public DateTime? MCreateTime {get;set;}


		/// <summary>
		/// 【消息类型】[-1，Unknown
		///             0，Text
		///             1，Location
		///             2，Image
		///             3，Voice
		///             4，Video
		///             5，Link
		///             6，ShortVideo
		///             7，Event
		///             8，File
		///             999，NeuChar
		///             ]
		/// </summary>
		[JsonProperty("消息类型")]
		public MsgTypeEnum? MsgType {get;set;}


		/// <summary>
		/// 【事件类型】[0，ENTER
		///             1，LOCATION
		///             2，subscribe
		///             3，unsubscribe
		///             4，CLICK
		///             5，scan
		///             6，VIEW
		///             7，MASSSENDJOBFINISH
		///             8，TEMPLATESENDJOBFINISH
		///             9，scancode_push
		///             10，scancode_waitmsg
		///             11，pic_sysphoto
		///             12，pic_photo_or_album
		///             13，pic_weixin
		///             14，location_select
		///             15，card_pass_check]
		/// </summary>
		[JsonProperty("事件类型")]
		public EventEnum? Event {get;set;}


		/// <summary>
		/// 【事件KEY值】
		/// </summary>
		[JsonProperty("事件KEY值")]
		public string EventKey {get;set;}


		/// <summary>
		/// 【二维码的ticket】
		/// </summary>
		[JsonProperty("二维码的ticket")]
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



	}
}
