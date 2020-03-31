using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【消息类型】
	/// </summary>
	[Table("MessageType")]
	public partial class MessageType:BaseEntity
	{
		/// <summary>
		/// 【消息类型ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  int MessageTypeID {get;set;}


		/// <summary>
		/// 【短信模板ID】
		/// </summary>
		public int? PhoneTemplateID {get;set;}
		/// <summary>
		/// 【短信模板ID】
		/// </summary>
		[ForeignKey("PhoneTemplateID")]
		public virtual PhoneTemplate PhoneTemplate {get;set;}


		/// <summary>
		/// 【微信模板ID】
		/// </summary>
		public int? WeixinTemplateID {get;set;}
		/// <summary>
		/// 【微信模板ID】
		/// </summary>
		[ForeignKey("WeixinTemplateID")]
		public virtual WeixinTemplate WeixinTemplate {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[MaxLength(50)]
		public string Name {get;set;}


		/// <summary>
		/// 【值】
		/// </summary>
		public byte? Value {get;set;}


		/// <summary>
		/// 【发送类型】
		/// </summary>
		public byte? SendType {get;set;}


		/// <summary>
		/// 【备注】
		/// </summary>
		[MaxLength(200)]
		public string Remark {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【消息推送】
		/// </summary>
		public virtual ICollection<Message> Message {get;set;}



	}
}
