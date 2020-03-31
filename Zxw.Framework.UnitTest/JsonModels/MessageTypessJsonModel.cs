using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 
	/// </summary>
	public partial class MessageTypessModel
	{
		/// <summary>
		/// 【消息类型ID】
		/// </summary>
		[JsonProperty("消息类型ID")]
		public int? MessageTypeID {get;set;}


		/// <summary>
		/// 【短信模板ID】
		/// </summary>
		[JsonProperty("短信模板ID")]
		public int? PhoneTemplateID {get;set;}


		/// <summary>
		/// 【微信模板ID】
		/// </summary>
		[JsonProperty("微信模板ID")]
		public int? WeixinTemplateID {get;set;}


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
		///             [0，短信+微信
		///             10，微信
		///             20，短信]
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



	}
}
