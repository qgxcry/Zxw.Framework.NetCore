using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【医务人员】
	/// </summary>
	[Table("MedicalStaff")]
	public partial class MedicalStaff:BaseEntity
	{
		/// <summary>
		/// 【医务人员ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  int MedicalStaffID {get;set;}


		/// <summary>
		/// 【科室ID】
		/// </summary>
		public int? DepartmentID {get;set;}
		/// <summary>
		/// 【科室ID】
		/// </summary>
		[ForeignKey("DepartmentID")]
		public virtual Departments Departments {get;set;}


		/// <summary>
		/// 【医院ID】
		/// </summary>
		public int? HospitalID {get;set;}
		/// <summary>
		/// 【医院ID】
		/// </summary>
		[ForeignKey("HospitalID")]
		public virtual Hospitals Hospitals {get;set;}


		/// <summary>
		/// 【医务人员编号】
		/// </summary>
		[MaxLength(50)]
		public string MedicalStaffNO {get;set;}


		/// <summary>
		/// 【姓名】
		/// </summary>
		[MaxLength(50)]
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
		[MaxLength(200)]
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
