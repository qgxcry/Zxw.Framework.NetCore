using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【登陆日志】
	/// </summary>
	public partial class UserLoginLogDto
	{
		/// <summary>
		/// 【日志ID】
		/// </summary>
		public long LoginLogID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}
		/// <summary>
		/// 【用户ID】
		/// </summary>
		public virtual UserDto User {get;set;}


		/// <summary>
		/// 【注册时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【IP地址】
		/// </summary>
		public string IP {get;set;}


		/// <summary>
		/// 【PCUUID】
		/// </summary>
		public string PCUUID {get;set;}



	}
}
