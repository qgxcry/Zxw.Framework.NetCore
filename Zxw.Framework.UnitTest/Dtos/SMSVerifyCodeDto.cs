using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【手机短信验证】
	/// </summary>
	public partial class SMSVerifyCodeDto
	{
		/// <summary>
		/// 【短信验证ID】
		/// </summary>
		public long? SMSVerifyCodeID {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		public string Phone {get;set;}


		/// <summary>
		/// 【验证码】
		/// </summary>
		public string VCode {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【过期时间】
		/// </summary>
		public DateTime? ExpireTime {get;set;}


		/// <summary>
		/// 【发送消息】
		/// </summary>
		public string Message {get;set;}



	}
}
