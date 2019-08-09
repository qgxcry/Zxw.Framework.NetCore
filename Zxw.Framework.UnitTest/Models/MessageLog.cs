using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【消息发送记录】
	/// </summary>
	[Table("MessageLog")]
	public partial class MessageLog:BaseEntity
	{
		/// <summary>
		/// 【消息记录ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  long MessageLogID {get;set;}


		/// <summary>
		/// 【消息ID】
		/// </summary>
		public long? MessageID {get;set;}
		/// <summary>
		/// 【消息ID】
		/// </summary>
		[ForeignKey("MessageID")]
		public virtual Message Message {get;set;}


		/// <summary>
		/// 【消息发送类型】[0，微信
		///             1，短信]
		/// </summary>
		public SendTypeEnum? SendType {get;set;}


		/// <summary>
		/// 【手机号】
		/// </summary>
		[MaxLength(200)]
		public string Phone {get;set;}


		/// <summary>
		/// 【微信OpenId】
		/// </summary>
		[MaxLength(50)]
		public string OpenId {get;set;}


		/// <summary>
		/// 【状态】[0，失败
		///             1，成功]
		/// </summary>
		public StatusEnum? Status {get;set;}


		/// <summary>
		/// 【返回信息】
		/// </summary>
		[MaxLength(500)]
		public string Info {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}



	}
}
