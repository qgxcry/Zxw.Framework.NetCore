using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【登陆日志】
	/// </summary>
	[Table("UserLoginLog")]
	public partial class UserLoginLog:BaseEntity
	{
		/// <summary>
		/// 【日志ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  long LoginLogID {get;set;}


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
		/// 【注册时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【IP地址】
		/// </summary>
		[MaxLength(50)]
		public string IP {get;set;}


		/// <summary>
		/// 【PCUUID】
		/// </summary>
		[MaxLength(50)]
		public string PCUUID {get;set;}



	}
}
