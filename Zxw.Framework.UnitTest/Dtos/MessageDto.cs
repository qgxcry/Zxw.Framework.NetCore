using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【消息推送】
	/// </summary>
	public partial class MessageDto
	{
		/// <summary>
		/// 【消息ID】
		/// </summary>
		public long MessageID {get;set;}


		/// <summary>
		/// 【消息类型ID】
		/// </summary>
		public int? MessageTypeID {get;set;}
		/// <summary>
		/// 【消息类型ID】
		/// </summary>
		public virtual MessageTypeDto MessageType {get;set;}


		/// <summary>
		/// 【消息标题】
		/// </summary>
		public string Title {get;set;}


		/// <summary>
		/// 【简介】
		/// </summary>
		public string Meat {get;set;}


		/// <summary>
		/// 【消息内容】
		/// </summary>
		public string Content {get;set;}


		/// <summary>
		/// 【站点ID】
		/// </summary>
		public int? SiteID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【备注】
		/// </summary>
		public string Remark {get;set;}


		/// <summary>
		/// 【MD5校验】
		/// </summary>
		public string MD5Valid {get;set;}


		/// <summary>
		/// 【消息发送时间】
		/// </summary>
		public DateTime? SendTime {get;set;}


		/// <summary>
		/// 【短信数据】
		/// </summary>
		public string PhoneDate {get;set;}


		/// <summary>
		/// 【微信数据】
		/// </summary>
		public string WeixinDate {get;set;}


		/// <summary>
		/// 【是否已发送短信】
		/// </summary>
		public byte? IsSendPhone {get;set;}


		/// <summary>
		/// 【是否已推送微信】
		/// </summary>
		public byte? IsSendWeixin {get;set;}


		/// <summary>
		/// 【短信发送时间】
		/// </summary>
		public DateTime? SendPhoneTime {get;set;}


		/// <summary>
		/// 【微信推送时间】
		/// </summary>
		public DateTime? SendWeixinTime {get;set;}


		/// <summary>
		/// 【短信发送次数】
		/// </summary>
		public int? SendPhoneCount {get;set;}


		/// <summary>
		/// 【微信推送次数】
		/// </summary>
		public int? SendWeixinCount {get;set;}


		/// <summary>
		/// 【是否已读】
		/// </summary>
		public byte? IsRead {get;set;}


		/// <summary>
		/// 【阅读时间】
		/// </summary>
		public DateTime? ReadTime {get;set;}


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
		/// 【消息发送记录】
		/// </summary>
		public virtual ICollection<MessageLogDto> MessageLog {get;set;}



	}
}
