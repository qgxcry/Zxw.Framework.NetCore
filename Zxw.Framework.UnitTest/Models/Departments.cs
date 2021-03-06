using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Models
{
	/// <summary>
	/// 【科室】
	/// </summary>
	[Table("Departments")]
	public partial class Departments:BaseEntity
	{
		/// <summary>
		/// 【科室ID】
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public  int DepartmentID {get;set;}


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
		/// 【科室编号】
		/// </summary>
		[MaxLength(50)]
		public string DNO {get;set;}


		/// <summary>
		/// 【科室名称】
		/// </summary>
		[MaxLength(50)]
		public string DName {get;set;}


		/// <summary>
		/// 【科室类型编码】
		/// </summary>
		[MaxLength(10)]
		public string DepartmentType {get;set;}


		/// <summary>
		/// 【说明】
		/// </summary>
		[MaxLength(200)]
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
		public virtual ICollection<MedicalStaff> MedicalStaff {get;set;}



	}
}
