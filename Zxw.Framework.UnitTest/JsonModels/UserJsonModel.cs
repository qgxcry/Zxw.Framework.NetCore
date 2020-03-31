using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【注册用户】
	/// </summary>
	public partial class UserModel
	{
		/// <summary>
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}


		/// <summary>
		/// 【用户登录账号】
		/// </summary>
		[JsonProperty("用户登录账号")]
		public string LoginName {get;set;}


		/// <summary>
		/// 【用户登录密码】
		/// </summary>
		[JsonProperty("用户登录密码")]
		public string Password {get;set;}


		/// <summary>
		/// 【身份证号】
		/// </summary>
		[JsonProperty("身份证号")]
		public string IDNumber {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		[JsonProperty("手机号")]
		public string Phone {get;set;}


		/// <summary>
		/// 【用户邮箱】
		/// </summary>
		[JsonProperty("用户邮箱")]
		public string UserEmail {get;set;}


		/// <summary>
		/// 【用户昵称】
		/// </summary>
		[JsonProperty("用户昵称")]
		public string UserName {get;set;}


		/// <summary>
		/// 【性别】
		/// </summary>
		[JsonProperty("性别")]
		public byte? Gender {get;set;}


		/// <summary>
		/// 【区域ID】
		/// </summary>
		[JsonProperty("区域ID")]
		public int? AreaID {get;set;}


		/// <summary>
		/// 【所在省份】
		/// </summary>
		[JsonProperty("所在省份")]
		public string Province {get;set;}


		/// <summary>
		/// 【所在城市】
		/// </summary>
		[JsonProperty("所在城市")]
		public string City {get;set;}


		/// <summary>
		/// 【所在区县】
		/// </summary>
		[JsonProperty("所在区县")]
		public string District {get;set;}


		/// <summary>
		/// 【区域代码】
		/// </summary>
		[JsonProperty("区域代码")]
		public string AreaCode {get;set;}


		/// <summary>
		/// 【用户头像】
		/// </summary>
		[JsonProperty("用户头像")]
		public string UserImage {get;set;}


		/// <summary>
		/// 【用户类型】
		/// </summary>
		[JsonProperty("用户类型")]
		public byte? UserType {get;set;}


		/// <summary>
		/// 【注册时间】
		/// </summary>
		[JsonProperty("注册时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【最后登陆时间】
		/// </summary>
		[JsonProperty("最后登陆时间")]
		public DateTime? LastLoginTime {get;set;}


		/// <summary>
		/// 【二次加密的串】
		/// </summary>
		[JsonProperty("二次加密的串")]
		public string Salt {get;set;}


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


		/// <summary>
		/// 【当前医院ID】
		/// </summary>
		[JsonProperty("当前医院ID")]
		public int? HospitalID {get;set;}


		/// <summary>
		/// 【当前产检ID】
		/// </summary>
		[JsonProperty("当前产检ID")]
		public long? ArchiveID {get;set;}


		/// <summary>
		/// 【微信OpenId】
		/// </summary>
		[JsonProperty("微信OpenId")]
		public string OpenId {get;set;}


		/// <summary>
		/// 【微信UnionId】
		/// </summary>
		[JsonProperty("微信UnionId")]
		public string UnionId {get;set;}


		/// <summary>
		/// 【当前站点ID】
		/// </summary>
		[JsonProperty("当前站点ID")]
		public int? SiteID {get;set;}


		/// <summary>
		/// 【绑定账号】
		/// </summary>
		public virtual ICollection<UserAccountsJsonModel> UserAccounts {get;set;}


		/// <summary>
		/// 【登陆日志】
		/// </summary>
		public virtual ICollection<UserLoginLogJsonModel> UserLoginLog {get;set;}



	}
}
