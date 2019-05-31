using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【短信模板】
	/// </summary>
	public partial class PhoneTemplateDto
	{
		/// <summary>
		/// 【短信模板ID】
		/// </summary>
		public int PhoneTemplateID {get;set;}


		/// <summary>
		/// 【短信签名】短信签名-可在短信控制台中找到
		/// </summary>
		public string SignName {get;set;}


		/// <summary>
		/// 【短信模板】短信模板-可在短信控制台中找到
		/// </summary>
		public string TemplateCode {get;set;}


		/// <summary>
		/// 【模板参数】可选:模板中的变量替换JSON串,如模板内容为"亲爱的${name},您的验证码为${code}"时,此处的值为{name:"",code:""}
		/// </summary>
		public string TemplateParam {get;set;}


		/// <summary>
		/// 【备注】
		/// </summary>
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
		public virtual ICollection<MessageTypeDto> MessageType {get;set;}



	}
}
