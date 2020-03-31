using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ZLHP.Enums;

namespace ZLHP.DataCenter.Apis.Models
{
	/// <summary>
	/// 【预约记录】
	/// </summary>
	public partial class RegisterRecordsModel
	{
		/// <summary>
		/// 【预约记录ID】
		/// </summary>
		[JsonProperty("预约记录ID")]
		public long? RegisterRecordID {get;set;}


		/// <summary>
		/// 【站点ID】
		/// </summary>
		[JsonProperty("站点ID")]
		public int? SiteID {get;set;}


		/// <summary>
		/// 【用户ID】
		/// </summary>
		[JsonProperty("用户ID")]
		public int? UserID {get;set;}


		/// <summary>
		/// 【档案ID】
		/// </summary>
		[JsonProperty("档案ID")]
		public long? ArchiveID {get;set;}


		/// <summary>
		/// 【排班编号】
		/// </summary>
		[JsonProperty("排班编号")]
		public string ProCode {get;set;}


		/// <summary>
		/// 【预约类型】[1，当日
		///             2，预约]
		/// </summary>
		[JsonProperty("预约类型")]
		public RegistrationTypeEnum? RegistrationType {get;set;}


		/// <summary>
		/// 【挂号单】
		/// </summary>
		[JsonProperty("挂号单")]
		public string BillNo {get;set;}


		/// <summary>
		/// 【病人ID】
		/// </summary>
		[JsonProperty("病人ID")]
		public string PatientId {get;set;}


		/// <summary>
		/// 【科室ID】
		/// </summary>
		[JsonProperty("科室ID")]
		public string DepartmentId {get;set;}


		/// <summary>
		/// 【科室名称】
		/// </summary>
		[JsonProperty("科室名称")]
		public string DepartmentName {get;set;}


		/// <summary>
		/// 【诊室】
		/// </summary>
		[JsonProperty("诊室")]
		public string Room {get;set;}


		/// <summary>
		/// 【提示】
		/// </summary>
		[JsonProperty("提示")]
		public string Tips {get;set;}


		/// <summary>
		/// 【金额】
		/// </summary>
		[JsonProperty("金额")]
		public float? Price {get;set;}


		/// <summary>
		/// 【挂号费】
		/// </summary>
		[JsonProperty("挂号费")]
		public float? RegFee {get;set;}


		/// <summary>
		/// 【诊察费】
		/// </summary>
		[JsonProperty("诊察费")]
		public float? TreatFee {get;set;}


		/// <summary>
		/// 【医生ID】
		/// </summary>
		[JsonProperty("医生ID")]
		public string DoctorId {get;set;}


		/// <summary>
		/// 【医生姓名】
		/// </summary>
		[JsonProperty("医生姓名")]
		public string DoctorName {get;set;}


		/// <summary>
		/// 【预约日期】
		/// </summary>
		[JsonProperty("预约日期")]
		public DateTime? BespeakTime {get;set;}


		/// <summary>
		/// 【时段类型】[0，凌晨
		///             1，上午
		///             2，下午
		///             3，晚上]
		/// </summary>
		[JsonProperty("时段类型")]
		public TimeIntervalTypeEnum? TimeIntervalType {get;set;}


		/// <summary>
		/// 【预约号】
		/// </summary>
		[JsonProperty("预约号")]
		public int? RegisterNumber {get;set;}


		/// <summary>
		/// 【开始时间】
		/// </summary>
		[JsonProperty("开始时间")]
		public DateTime? StartTime {get;set;}


		/// <summary>
		/// 【结束时间】
		/// </summary>
		[JsonProperty("结束时间")]
		public DateTime? EndTime {get;set;}


		/// <summary>
		/// 【是否付费】
		/// </summary>
		[JsonProperty("是否付费")]
		public byte? IsPay {get;set;}


		/// <summary>
		/// 【流水号】
		/// </summary>
		[JsonProperty("流水号")]
		public string SerialNumber {get;set;}


		/// <summary>
		/// 【状态】[0，待支付
		///             1，已预约
		///             2，已取消]
		/// </summary>
		[JsonProperty("状态")]
		public RegisterStatusEnum? RegisterStatus {get;set;}


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
		/// 【创建时间】
		/// </summary>
		[JsonProperty("创建时间")]
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【更新时间】
		/// </summary>
		[JsonProperty("更新时间")]
		public DateTime? UpdateTime {get;set;}



	}
}
