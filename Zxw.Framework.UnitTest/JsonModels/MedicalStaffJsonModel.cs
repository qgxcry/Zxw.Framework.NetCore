using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【医务人员】
	/// </summary>
	public partial class MedicalStaffModel
	{
		/// <summary>
		/// 【医务人员ID】
		/// </summary>
		[JsonProperty("医务人员ID")]
		public int? MedicalStaffID {get;set;}


		/// <summary>
		/// 【科室ID】
		/// </summary>
		[JsonProperty("科室ID")]
		public int? DepartmentID {get;set;}
		/// <summary>
		/// 【科室ID】
		/// </summary>
		public virtual DepartmentsJsonModel Departments {get;set;}


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
		/// 【医务人员编号】
		/// </summary>
		[JsonProperty("医务人员编号")]
		public string MedicalStaffNO {get;set;}


		/// <summary>
		/// 【姓名】
		/// </summary>
		[JsonProperty("姓名")]
		public string Name {get;set;}


		/// <summary>
		/// 【职称】[0，无
		///             1，助理医师
		///             2，医师
		///             3，主治医师
		///             4，副主任医师
		///             5，主任医师
		///             ]
		/// </summary>
		[JsonProperty("职称")]
		public ProfessionalTitleEnum? ProfessionalTitle {get;set;}


		/// <summary>
		/// 【简介】
		/// </summary>
		[JsonProperty("简介")]
		public string Introduction {get;set;}


		/// <summary>
		/// 【职务】
		/// </summary>
		[JsonProperty("职务")]
		public byte? Post {get;set;}


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
