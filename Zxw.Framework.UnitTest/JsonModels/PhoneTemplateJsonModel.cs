using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【短信模板】
	/// </summary>
	public partial class PhoneTemplateModel
	{
		/// <summary>
		/// 【短信模板ID】
		/// </summary>
		[JsonProperty("短信模板ID")]
		public int? PhoneTemplateID {get;set;}


		/// <summary>
		/// 【短信签名】短信签名-可在短信控制台中找到
		/// </summary>
		[JsonProperty("短信签名")]
		public string SignName {get;set;}


		/// <summary>
		/// 【短信模板】短信模板-可在短信控制台中找到
		/// </summary>
		[JsonProperty("短信模板")]
		public string TemplateCode {get;set;}


		/// <summary>
		/// 【模板参数】可选:模板中的变量替换JSON串,如模板内容为"亲爱的${name},您的验证码为${code}"时,此处的值为{name:"",code:""}
		/// </summary>
		[JsonProperty("模板参数")]
		public string TemplateParam {get;set;}


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
