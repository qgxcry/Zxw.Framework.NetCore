using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【医院】
	/// </summary>
	public partial class HospitalsDto
	{
		/// <summary>
		/// 【医院ID】
		/// </summary>
		public int HospitalID {get;set;}


		/// <summary>
		/// 【医院编号】
		/// </summary>
		public string HNo {get;set;}


		/// <summary>
		/// 【医院名称】
		/// </summary>
		public string HName {get;set;}


		/// <summary>
		/// 【医院简介】
		/// </summary>
		public string HDescription {get;set;}


		/// <summary>
		/// 【省份】
		/// </summary>
		public string Province {get;set;}


		/// <summary>
		/// 【城市】
		/// </summary>
		public string City {get;set;}


		/// <summary>
		/// 【区县】
		/// </summary>
		public string District {get;set;}


		/// <summary>
		/// 【医院地址】
		/// </summary>
		public string Address {get;set;}


		/// <summary>
		/// 【等级】
		/// </summary>
		public byte? Level {get;set;}


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
		/// 【科室】
		/// </summary>
		public virtual ICollection<DepartmentsDto> Departments {get;set;}


		/// <summary>
		/// 【医务人员】
		/// </summary>
		public virtual ICollection<MedicalStaffDto> MedicalStaff {get;set;}



	}
}
