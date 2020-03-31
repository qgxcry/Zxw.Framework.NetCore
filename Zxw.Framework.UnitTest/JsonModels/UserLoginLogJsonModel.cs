using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【登陆日志】
	/// </summary>
	public partial class UserLoginLogModel
	{
		/// <summary>
		/// 【日志ID】
		/// </summary>
		[JsonProperty("日志ID")]
		public long? LoginLogID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}
		/// <summary>
		/// 【用户ID】
		/// </summary>
		public virtual UserJsonModel User {get;set;}


		/// <summary>
		/// 【注册时间】
		/// </summary>
		[JsonProperty("注册时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【IP地址】
		/// </summary>
		[JsonProperty("IP地址")]
		public string IP {get;set;}


		/// <summary>
		/// 【PCUUID】
		/// </summary>
		[JsonProperty("PCUUID")]
		public string PCUUID {get;set;}



	}
}
