using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【公众号站点】
	/// </summary>
	[Table("Sites")]
	public partial class Sites:BaseEntity
	{
		/// <summary>
		/// 【公众号站点ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  int SiteID {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		public int? HospitalID {get;set;}


		/// <summary>
		/// 【医院名称】
		/// </summary>
		[MaxLength(50)]
		public string HospitalName {get;set;}


		/// <summary>
		/// 【医院编号】
		/// </summary>
		[MaxLength(50)]
		public string HospitalNo {get;set;}


		/// <summary>
		/// 【医院图片】
		/// </summary>
		[MaxLength(100)]
		public string Image {get;set;}


		/// <summary>
		/// 【站点URL】
		/// </summary>
		[MaxLength(50)]
		public string SiteUrl {get;set;}


		/// <summary>
		/// 【站点编码】
		/// </summary>
		[MaxLength(50)]
		public string SNO {get;set;}


		/// <summary>
		/// 【简介】
		/// </summary>
		[MaxLength(200)]
		public string Description {get;set;}


		/// <summary>
		/// 【等级】
		/// </summary>
		public byte? Level {get;set;}


		/// <summary>
		/// 【二维码ID】
		/// </summary>
		public long? QrCodeID {get;set;}


		/// <summary>
		/// 【医院参数ID】
		/// </summary>
		public int? SceneId {get;set;}


		/// <summary>
		/// 【区域代码】
		/// </summary>
		[MaxLength(50)]
		public string AreaCode {get;set;}


		/// <summary>
		/// 【医院地址】
		/// </summary>
		[MaxLength(50)]
		public string Address {get;set;}


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
		/// 【是否提供接口】
		/// </summary>
		public byte? IsServer {get;set;}


		/// <summary>
		/// 【服务器秘钥】
		/// </summary>
		[MaxLength(50)]
		public string ServerSercret {get;set;}


		/// <summary>
		/// 【服务器地址】
		/// </summary>
		[MaxLength(50)]
		public string ServerAddress {get;set;}


		/// <summary>
		/// 【栏目配置】
		/// </summary>
		public virtual ICollection<Sections> Sections {get;set;}



	}
}
