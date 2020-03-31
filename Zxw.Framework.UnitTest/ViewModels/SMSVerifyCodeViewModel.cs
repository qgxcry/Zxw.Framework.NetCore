using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Web.Models
{
	/// <summary>
	/// 【手机短信验证】
	/// </summary>
	public partial class SMSVerifyCodeViewModel
	{
		/// <summary>
		/// 【短信验证ID】
		/// </summary>
		public long? SMSVerifyCodeID {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		[MaxLength(50)]
		public string Phone {get;set;}


		/// <summary>
		/// 【验证码】
		/// </summary>
		[MaxLength(10)]
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
		[MaxLength(200)]
		public string Message {get;set;}



	}
}
