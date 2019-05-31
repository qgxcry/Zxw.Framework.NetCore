using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【行政区域】
	/// </summary>
	public partial class SYS_AreaModel
	{
		/// <summary>
		/// 【区域ID】
		/// </summary>
		[JsonProperty("区域ID")]
		public int AreaID {get;set;}


		/// <summary>
		/// 【父区域ID】
		/// </summary>
		[JsonProperty("父区域ID")]
		public int? AreaPID {get;set;}


		/// <summary>
		/// 【区域名称】
		/// </summary>
		[JsonProperty("区域名称")]
		public string AreaName {get;set;}


		/// <summary>
		/// 【区域代码】
		/// </summary>
		[JsonProperty("区域代码")]
		public string AreaCode {get;set;}


		/// <summary>
		/// 【区域类型】1：>大区域（华北、华南、西北、西南等）
		///             2：>省份/直辖市
		///             3：>地级市
		///             4：>县级市/县
		/// </summary>
		[JsonProperty("区域类型")]
		public byte? AreaType {get;set;}


		/// <summary>
		/// 【是否禁用】
		/// </summary>
		[JsonProperty("是否禁用")]
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【是否热门】
		/// </summary>
		[JsonProperty("是否热门")]
		public byte? IsHot {get;set;}


		/// <summary>
		/// 【汉字拼音】
		/// </summary>
		[JsonProperty("汉字拼音")]
		public string LetterFirst {get;set;}


		/// <summary>
		/// 【简拼】
		/// </summary>
		[JsonProperty("简拼")]
		public string JianPin {get;set;}


		/// <summary>
		/// 【拼音】
		/// </summary>
		[JsonProperty("拼音")]
		public string PinYin {get;set;}


		/// <summary>
		/// 是否删除
		/// </summary>
		[JsonProperty("")]
		public byte? IsDeleted {get;set;}



	}
}
