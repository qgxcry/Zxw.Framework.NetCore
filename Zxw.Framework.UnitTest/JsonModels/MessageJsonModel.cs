using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【消息推送】
	/// </summary>
	public partial class MessageModel
	{
		/// <summary>
		/// 【消息ID】
		/// </summary>
		[JsonProperty("消息ID")]
		public long? MessageID {get;set;}


		/// <summary>
		/// 【消息类型ID】
		/// </summary>
		[JsonProperty("消息类型ID")]
		public int? MessageTypeID {get;set;}
		/// <summary>
		/// 【消息类型ID】
		/// </summary>
		public virtual MessageTypeJsonModel MessageType {get;set;}


		/// <summary>
		/// 【消息标题】
		/// </summary>
		[JsonProperty("消息标题")]
		public string Title {get;set;}


		/// <summary>
		/// 【简介】
		/// </summary>
		[JsonProperty("简介")]
		public string Meat {get;set;}


		/// <summary>
		/// 【消息内容】
		/// </summary>
		[JsonProperty("消息内容")]
		public string Content {get;set;}


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
		/// 【备注】
		/// </summary>
		[JsonProperty("备注")]
		public string Remark {get;set;}


		/// <summary>
		/// 【MD5校验】
		/// </summary>
		[JsonProperty("MD5校验")]
		public string MD5Valid {get;set;}


		/// <summary>
		/// 【消息发送时间】
		/// </summary>
		[JsonProperty("消息发送时间")]
		public DateTime? SendTime {get;set;}


		/// <summary>
		/// 【短信数据】
		/// </summary>
		[JsonProperty("短信数据")]
		public string PhoneDate {get;set;}


		/// <summary>
		/// 【微信数据】
		/// </summary>
		[JsonProperty("微信数据")]
		public string WeixinDate {get;set;}


		/// <summary>
		/// 【是否已发送短信】
		/// </summary>
		[JsonProperty("是否已发送短信")]
		public byte? IsSendPhone {get;set;}


		/// <summary>
		/// 【是否已推送微信】
		/// </summary>
		[JsonProperty("是否已推送微信")]
		public byte? IsSendWeixin {get;set;}


		/// <summary>
		/// 【短信发送时间】
		/// </summary>
		[JsonProperty("短信发送时间")]
		public DateTime? SendPhoneTime {get;set;}


		/// <summary>
		/// 【微信推送时间】
		/// </summary>
		[JsonProperty("微信推送时间")]
		public DateTime? SendWeixinTime {get;set;}


		/// <summary>
		/// 【短信发送次数】
		/// </summary>
		[JsonProperty("短信发送次数")]
		public int? SendPhoneCount {get;set;}


		/// <summary>
		/// 【微信推送次数】
		/// </summary>
		[JsonProperty("微信推送次数")]
		public int? SendWeixinCount {get;set;}


		/// <summary>
		/// 【是否已读】
		/// </summary>
		[JsonProperty("是否已读")]
		public byte? IsRead {get;set;}


		/// <summary>
		/// 【阅读时间】
		/// </summary>
		[JsonProperty("阅读时间")]
		public DateTime? ReadTime {get;set;}


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
		/// 【消息发送记录】
		/// </summary>
		public virtual ICollection<MessageLogJsonModel> MessageLog {get;set;}



	}
}
