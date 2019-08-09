using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【公众号站点】
	/// </summary>
	public partial class SitesModel
	{
		/// <summary>
		/// 【公众号站点ID】
		/// </summary>
		[JsonProperty("公众号站点ID")]
		public int SiteID {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		[JsonProperty("医院ID")]
		public int? HospitalID {get;set;}


		/// <summary>
		/// 【医院名称】
		/// </summary>
		[JsonProperty("医院名称")]
		public string HospitalName {get;set;}


		/// <summary>
		/// 【医院编号】
		/// </summary>
		[JsonProperty("医院编号")]
		public string HospitalNo {get;set;}


		/// <summary>
		/// 【医院图片】
		/// </summary>
		[JsonProperty("医院图片")]
		public string Image {get;set;}


		/// <summary>
		/// 【站点URL】
		/// </summary>
		[JsonProperty("站点URL")]
		public string SiteUrl {get;set;}


		/// <summary>
		/// 【站点编码】
		/// </summary>
		[JsonProperty("站点编码")]
		public string SNO {get;set;}


		/// <summary>
		/// 【简介】
		/// </summary>
		[JsonProperty("简介")]
		public string Description {get;set;}


		/// <summary>
		/// 【等级】
		/// </summary>
		[JsonProperty("等级")]
		public byte? Level {get;set;}


		/// <summary>
		/// 【二维码ID】
		/// </summary>
		[JsonProperty("二维码ID")]
		public long? QrCodeID {get;set;}


		/// <summary>
		/// 【二维码参数】
		/// </summary>
		[JsonProperty("二维码参数")]
		public int? SceneId {get;set;}


		/// <summary>
		/// 【接口授权秘钥】
		/// </summary>
		[JsonProperty("接口授权秘钥")]
		public string AppSecret {get;set;}


		/// <summary>
		/// 【是否提供接口】
		/// </summary>
		[JsonProperty("是否提供接口")]
		public byte? IsServer {get;set;}


		/// <summary>
		/// 【服务器秘钥】
		/// </summary>
		[JsonProperty("服务器秘钥")]
		public string ServerSercret {get;set;}


		/// <summary>
		/// 【服务器地址】
		/// </summary>
		[JsonProperty("服务器地址")]
		public string ServerAddress {get;set;}


		/// <summary>
		/// 【His服务商类型】
		/// </summary>
		[JsonProperty("His服务商类型")]
		public string HisCompany {get;set;}


		/// <summary>
		/// 【His接口地址】
		/// </summary>
		[JsonProperty("His接口地址")]
		public string HisAddress {get;set;}


		/// <summary>
		/// 【His秘钥】
		/// </summary>
		[JsonProperty("His秘钥")]
		public string HisSecret {get;set;}


		/// <summary>
		/// 【His服务器名称】
		/// </summary>
		[JsonProperty("His服务器名称")]
		public string HisServerName {get;set;}


		/// <summary>
		/// 【微信子商户号】
		/// </summary>
		[JsonProperty("微信子商户号")]
		public string WxSubMchid {get;set;}


		/// <summary>
		/// 【区域代码】
		/// </summary>
		[JsonProperty("区域代码")]
		public string AreaCode {get;set;}


		/// <summary>
		/// 【医院地址】
		/// </summary>
		[JsonProperty("医院地址")]
		public string Address {get;set;}


		/// <summary>
		/// 【经度】
		/// </summary>
		[JsonProperty("经度")]
		public decimal? Longitude {get;set;}


		/// <summary>
		/// 【纬度】
		/// </summary>
		[JsonProperty("纬度")]
		public decimal? Latitude {get;set;}


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
		/// 【栏目配置】
		/// </summary>
		public virtual ICollection<SectionsJsonModel> Sections {get;set;}



	}
}
