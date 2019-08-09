using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【消息发送记录】
	/// </summary>
	public partial class MessageLogModel
	{
		/// <summary>
		/// 【消息记录ID】
		/// </summary>
		[JsonProperty("消息记录ID")]
		public long MessageLogID {get;set;}


		/// <summary>
		/// 【消息ID】
		/// </summary>
		[JsonProperty("消息ID")]
		public long? MessageID {get;set;}
		/// <summary>
		/// 【消息ID】
		/// </summary>
		public virtual MessageJsonModel Message {get;set;}


		/// <summary>
		/// 【消息发送类型】[0，微信
		///             1，短信]
		/// </summary>
		[JsonProperty("消息发送类型")]
		public SendTypeEnum? SendType {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		[JsonProperty("手机号")]
		public string Phone {get;set;}


		/// <summary>
		/// 【微信OpenId】
		/// </summary>
		[JsonProperty("微信OpenId")]
		public string OpenId {get;set;}


		/// <summary>
		/// 【状态】[0，失败
		///             1，成功]
		/// </summary>
		[JsonProperty("状态")]
		public StatusEnum? Status {get;set;}


		/// <summary>
		/// 【返回信息】
		/// </summary>
		[JsonProperty("返回信息")]
		public string Info {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
		public DateTime? CreateTime {get;set;}



	}
}
