using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【手机短信验证】
	/// </summary>
	public partial class SMSVerifyCodeModel
	{
		/// <summary>
		/// 【短信验证ID】
		/// </summary>
		[JsonProperty("短信验证ID")]
		public long SMSVerifyCodeID {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		[JsonProperty("手机号")]
		public string Phone {get;set;}


		/// <summary>
		/// 【验证码】
		/// </summary>
		[JsonProperty("验证码")]
		public string VCode {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【过期时间】
		/// </summary>
		[JsonProperty("过期时间")]
		public DateTime? ExpireTime {get;set;}


		/// <summary>
		/// 【发送消息】
		/// </summary>
		[JsonProperty("发送消息")]
		public string Message {get;set;}



	}
}
