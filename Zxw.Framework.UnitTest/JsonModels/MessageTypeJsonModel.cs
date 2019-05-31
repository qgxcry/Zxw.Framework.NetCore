using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【消息类型】
	/// </summary>
	public partial class MessageTypeModel
	{
		/// <summary>
		/// 【消息类型ID】
		/// </summary>
		[JsonProperty("消息类型ID")]
		public int MessageTypeID {get;set;}


		/// <summary>
		/// 【短信模板ID】
		/// </summary>
		[JsonProperty("短信模板ID")]
		public int? PhoneTemplateID {get;set;}
		/// <summary>
		/// 【短信模板ID】
		/// </summary>
		public virtual PhoneTemplateJsonModel PhoneTemplate {get;set;}


		/// <summary>
		/// 【微信模板ID】
		/// </summary>
		[JsonProperty("微信模板ID")]
		public int? WeixinTemplateID {get;set;}
		/// <summary>
		/// 【微信模板ID】
		/// </summary>
		public virtual WeixinTemplateJsonModel WeixinTemplate {get;set;}


		/// <summary>
		/// 【名称】
		/// </summary>
		[JsonProperty("名称")]
		public string Name {get;set;}


		/// <summary>
		/// 【值】
		/// </summary>
		[JsonProperty("值")]
		public byte? Value {get;set;}


		/// <summary>
		/// 【发送类型】
		/// </summary>
		[JsonProperty("发送类型")]
		public byte? SendType {get;set;}


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
		/// 【消息推送】
		/// </summary>
		public virtual ICollection<MessageJsonModel> Message {get;set;}



	}
}
