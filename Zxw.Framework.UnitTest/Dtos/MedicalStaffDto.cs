using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【医务人员】
	/// </summary>
	public partial class MedicalStaffDto
	{
		/// <summary>
		/// 【医务人员ID】
		/// </summary>
		public int? MedicalStaffID {get;set;}


		/// <summary>
		/// 【科室ID】
		/// </summary>
		public int? DepartmentID {get;set;}
		/// <summary>
		/// 【科室ID】
		/// </summary>
		public virtual DepartmentsDto Departments {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		public int? HospitalID {get;set;}
		/// <summary>
		/// 【医院ID】
		/// </summary>
		public virtual HospitalsDto Hospitals {get;set;}


		/// <summary>
		/// 【医务人员编号】
		/// </summary>
		public string MedicalStaffNO {get;set;}


		/// <summary>
		/// 【姓名】
		/// </summary>
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
		public ProfessionalTitleEnum? ProfessionalTitle {get;set;}


		/// <summary>
		/// 【简介】
		/// </summary>
		public string Introduction {get;set;}


		/// <summary>
		/// 【职务】
		/// </summary>
		public byte? Post {get;set;}


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



	}
}
