using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【医院】
	/// </summary>
	public partial class HospitalsModel
	{
		/// <summary>
		/// 【医院ID】
		/// </summary>
		[JsonProperty("医院ID")]
		public int HospitalID {get;set;}


		/// <summary>
		/// 【医院编号】
		/// </summary>
		[JsonProperty("医院编号")]
		public string HNo {get;set;}


		/// <summary>
		/// 【医院名称】
		/// </summary>
		[JsonProperty("医院名称")]
		public string HName {get;set;}


		/// <summary>
		/// 【医院简介】
		/// </summary>
		[JsonProperty("医院简介")]
		public string HDescription {get;set;}


		/// <summary>
		/// 【省份】
		/// </summary>
		[JsonProperty("省份")]
		public string Province {get;set;}


		/// <summary>
		/// 【城市】
		/// </summary>
		[JsonProperty("城市")]
		public string City {get;set;}


		/// <summary>
		/// 【区县】
		/// </summary>
		[JsonProperty("区县")]
		public string District {get;set;}


		/// <summary>
		/// 【医院地址】
		/// </summary>
		[JsonProperty("医院地址")]
		public string Address {get;set;}


		/// <summary>
		/// 【等级】
		/// </summary>
		[JsonProperty("等级")]
		public byte? Level {get;set;}


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
		/// 【科室】
		/// </summary>
		public virtual ICollection<DepartmentsJsonModel> Departments {get;set;}


		/// <summary>
		/// 【医务人员】
		/// </summary>
		public virtual ICollection<MedicalStaffJsonModel> MedicalStaff {get;set;}



	}
}
