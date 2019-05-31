using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【微信模板】
	/// </summary>
	[Table("WeixinTemplate")]
	public partial class WeixinTemplate:BaseEntity
	{
		/// <summary>
		/// 【微信模板ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  int WeixinTemplateID {get;set;}


		/// <summary>
		/// 【模板名称】
		/// </summary>
		[MaxLength(50)]
		public string TemplateName {get;set;}


		/// <summary>
		/// 【模板ID】
		/// </summary>
		[MaxLength(50)]
		public string TemplateId {get;set;}


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
		/// 【消息类型】
		/// </summary>
		public virtual ICollection<MessageType> MessageType {get;set;}



	}
}
