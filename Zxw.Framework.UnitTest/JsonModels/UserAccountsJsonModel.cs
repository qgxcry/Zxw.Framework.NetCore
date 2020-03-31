using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【绑定账号】
	/// </summary>
	public partial class UserAccountsModel
	{
		/// <summary>
		/// 【绑定账号ID】
		/// </summary>
		[JsonProperty("绑定账号ID")]
		public int? UserAccountsID {get;set;}


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
		/// 【账号类型】1：QQ
		///             2：新浪微博
		///             3：微信
		/// </summary>
		[JsonProperty("账号类型")]
		public byte? AccountType {get;set;}


		/// <summary>
		/// 【账号名称】
		/// </summary>
		[JsonProperty("账号名称")]
		public string AccountName {get;set;}


		/// <summary>
		/// 【账号值】
		/// </summary>
		[JsonProperty("账号值")]
		public string AccountVaule {get;set;}


		/// <summary>
		/// 【注册时间】
		/// </summary>
		[JsonProperty("注册时间")]
		public DateTime? CreateTime {get;set;}


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
