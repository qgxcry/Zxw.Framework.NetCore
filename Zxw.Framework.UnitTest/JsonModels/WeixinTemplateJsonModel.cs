using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【微信模板】
	/// </summary>
	public partial class WeixinTemplateModel
	{
		/// <summary>
		/// 【微信模板ID】
		/// </summary>
		[JsonProperty("微信模板ID")]
		public int WeixinTemplateID {get;set;}


		/// <summary>
		/// 【模板名称】
		/// </summary>
		[JsonProperty("模板名称")]
		public string TemplateName {get;set;}


		/// <summary>
		/// 【模板ID】
		/// </summary>
		[JsonProperty("模板ID")]
		public string TemplateId {get;set;}


		/// <summary>
		/// 【备注】
		/// </summary>
		[JsonProperty("备注")]
		public string Remark {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		[JsonProperty("更新时间")]
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【消息类型】
		/// </summary>
		public virtual ICollection<MessageTypeJsonModel> MessageType {get;set;}



	}
}
