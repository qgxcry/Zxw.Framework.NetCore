using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【科室】
	/// </summary>
	public partial class DepartmentsModel
	{
		/// <summary>
		/// 【科室ID】
		/// </summary>
		[JsonProperty("科室ID")]
		public int DepartmentID {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		[JsonProperty("医院ID")]
		public int? HospitalID {get;set;}
		/// <summary>
		/// 【医院ID】
		/// </summary>
		public virtual HospitalsJsonModel Hospitals {get;set;}


		/// <summary>
		/// 【科室编号】
		/// </summary>
		[JsonProperty("科室编号")]
		public string DNO {get;set;}


		/// <summary>
		/// 【科室名称】
		/// </summary>
		[JsonProperty("科室名称")]
		public string DName {get;set;}


		/// <summary>
		/// 【科室类型编码】
		/// </summary>
		[JsonProperty("科室类型编码")]
		public string DepartmentType {get;set;}


		/// <summary>
		/// 【说明】
		/// </summary>
		[JsonProperty("说明")]
		public string Description {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		[JsonProperty("是否删除")]
		public byte? IsDeleted {get;set;}


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
		/// 【是否启用】
		/// </summary>
		[JsonProperty("是否启用")]
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【医务人员】
		/// </summary>
		public virtual ICollection<MedicalStaffJsonModel> MedicalStaff {get;set;}



	}
}
