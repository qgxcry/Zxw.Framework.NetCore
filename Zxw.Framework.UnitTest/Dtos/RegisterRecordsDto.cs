using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【预约记录】
	/// </summary>
	public partial class RegisterRecordsDto
	{
		/// <summary>
		/// 【预约记录ID】
		/// </summary>
		public long? RegisterRecordID {get;set;}


		/// <summary>
		/// 【站点ID】
		/// </summary>
		public int? SiteID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		public int? UserID {get;set;}


		/// <summary>
		/// 【档案ID】
		/// </summary>
		public long? ArchiveID {get;set;}


		/// <summary>
		/// 【排班编号】
		/// </summary>
		public string ProCode {get;set;}


		/// <summary>
		/// 【预约类型】[1，当日
		///             2，预约]
		/// </summary>
		public RegistrationTypeEnum? RegistrationType {get;set;}


		/// <summary>
		/// 【挂号单】
		/// </summary>
		public string BillNo {get;set;}


		/// <summary>
		/// 【病人ID】
		/// </summary>
		public string PatientId {get;set;}


		/// <summary>
		/// 【科室ID】
		/// </summary>
		public string DepartmentId {get;set;}


		/// <summary>
		/// 【科室名称】
		/// </summary>
		public string DepartmentName {get;set;}


		/// <summary>
		/// 【诊室】
		/// </summary>
		public string Room {get;set;}


		/// <summary>
		/// 【提示】
		/// </summary>
		public string Tips {get;set;}


		/// <summary>
		/// 【金额】
		/// </summary>
		public float? Price {get;set;}


		/// <summary>
		/// 【挂号费】
		/// </summary>
		public float? RegFee {get;set;}


		/// <summary>
		/// 【诊察费】
		/// </summary>
		public float? TreatFee {get;set;}


		/// <summary>
		/// 【医生ID】
		/// </summary>
		public string DoctorId {get;set;}


		/// <summary>
		/// 【医生姓名】
		/// </summary>
		public string DoctorName {get;set;}


		/// <summary>
		/// 【预约日期】
		/// </summary>
		public DateTime? BespeakTime {get;set;}


		/// <summary>
		/// 【时段类型】[0，凌晨
		///             1，上午
		///             2，下午
		///             3，晚上]
		/// </summary>
		public TimeIntervalTypeEnum? TimeIntervalType {get;set;}


		/// <summary>
		/// 【预约号】
		/// </summary>
		public int? RegisterNumber {get;set;}


		/// <summary>
		/// 【开始时间】
		/// </summary>
		public DateTime? StartTime {get;set;}


		/// <summary>
		/// 【结束时间】
		/// </summary>
		public DateTime? EndTime {get;set;}


		/// <summary>
		/// 【是否付费】
		/// </summary>
		public byte? IsPay {get;set;}


		/// <summary>
		/// 【流水号】
		/// </summary>
		public string SerialNumber {get;set;}


		/// <summary>
		/// 【状态】[0，待支付
		///             1，已预约
		///             2，已取消]
		/// </summary>
		public RegisterStatusEnum? RegisterStatus {get;set;}


		/// <summary>
		/// 【是否删除】
		/// </summary>
		public byte? IsDeleted {get;set;}


		/// <summary>
		/// 【是否启用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		public DateTime? UpdateTime {get;set;}



	}
}
