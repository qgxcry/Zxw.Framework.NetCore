using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【科室】
	/// </summary>
	public partial class DepartmentsDto
	{
		/// <summary>
		/// 【科室ID】
		/// </summary>
		public int DepartmentID {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		public int? HospitalID {get;set;}
		/// <summary>
		/// 【医院ID】
		/// </summary>
		public virtual HospitalsDto Hospitals {get;set;}


		/// <summary>
		/// 【科室编号】
		/// </summary>
		public string DNO {get;set;}


		/// <summary>
		/// 【科室名称】
		/// </summary>
		public string DName {get;set;}


		/// <summary>
		/// 【科室类型编码】
		/// </summary>
		public string DepartmentType {get;set;}


		/// <summary>
		/// 【说明】
		/// </summary>
		public string Description {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		public DateTime? UpdateTime {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【医务人员】
		/// </summary>
		public virtual ICollection<MedicalStaffDto> MedicalStaff {get;set;}



	}
}
