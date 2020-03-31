using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【绑定账号】
	/// </summary>
	[Table("UserAccounts")]
	public partial class UserAccounts:BaseEntity
	{
		/// <summary>
		/// 【绑定账号ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  int UserAccountsID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}
		/// <summary>
		/// 【用户ID】
		/// </summary>
		[ForeignKey("UserID")]
		public virtual User User {get;set;}


		/// <summary>
		/// 【账号类型】1：QQ
		///             2：新浪微博
		///             3：微信
		/// </summary>
		public byte? AccountType {get;set;}


		/// <summary>
		/// 【账号名称】
		/// </summary>
		[MaxLength(50)]
		public string AccountName {get;set;}


		/// <summary>
		/// 【账号值】
		/// </summary>
		[MaxLength(50)]
		public string AccountVaule {get;set;}


		/// <summary>
		/// 【注册时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}



	}
}
