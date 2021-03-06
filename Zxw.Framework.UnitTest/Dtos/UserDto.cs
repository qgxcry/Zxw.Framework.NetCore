using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【注册用户】
	/// </summary>
	public partial class UserDto
	{
		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【用户登录账号】
		/// </summary>
		public string LoginName {get;set;}


		/// <summary>
		/// 【用户登录密码】
		/// </summary>
		public string Password {get;set;}


		/// <summary>
		/// 【身份证号】
		/// </summary>
		public string IDNumber {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		public string Phone {get;set;}


		/// <summary>
		/// 【用户邮箱】
		/// </summary>
		public string UserEmail {get;set;}


		/// <summary>
		/// 【用户昵称】
		/// </summary>
		public string UserName {get;set;}


		/// <summary>
		/// 【性别】
		/// </summary>
		public byte? Gender {get;set;}


		/// <summary>
		/// 【区域ID】
		/// </summary>
		public int? AreaID {get;set;}


		/// <summary>
		/// 【所在省份】
		/// </summary>
		public string Province {get;set;}


		/// <summary>
		/// 【所在城市】
		/// </summary>
		public string City {get;set;}


		/// <summary>
		/// 【所在区县】
		/// </summary>
		public string District {get;set;}


		/// <summary>
		/// 【区域代码】
		/// </summary>
		public string AreaCode {get;set;}


		/// <summary>
		/// 【用户头像】
		/// </summary>
		public string UserImage {get;set;}


		/// <summary>
		/// 【用户类型】
		/// </summary>
		public byte? UserType {get;set;}


		/// <summary>
		/// 【注册时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【最后登陆时间】
		/// </summary>
		public DateTime? LastLoginTime {get;set;}


		/// <summary>
		/// 【二次加密的串】
		/// </summary>
		public string Salt {get;set;}


		/// <summary>
		/// 【IP地址】
		/// </summary>
		public string IP {get;set;}


		/// <summary>
		/// 【PCUUID】
		/// </summary>
		public string PCUUID {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【当前医院ID】
		/// </summary>
		public int? HospitalID {get;set;}


		/// <summary>
		/// 【当前产检ID】
		/// </summary>
		public long? ArchiveID {get;set;}


		/// <summary>
		/// 【微信OpenId】
		/// </summary>
		public string OpenId {get;set;}


		/// <summary>
		/// 【微信UnionId】
		/// </summary>
		public string UnionId {get;set;}


		/// <summary>
		/// 【当前站点ID】
		/// </summary>
		public int? SiteID {get;set;}


		/// <summary>
		/// 【绑定账号】
		/// </summary>
		public virtual ICollection<UserAccountsDto> UserAccounts {get;set;}


		/// <summary>
		/// 【登陆日志】
		/// </summary>
		public virtual ICollection<UserLoginLogDto> UserLoginLog {get;set;}



	}
}
