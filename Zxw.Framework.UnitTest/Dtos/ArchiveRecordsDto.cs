using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 【产检记录】
	/// </summary>
	public partial class ArchiveRecordsDto
	{
		/// <summary>
		/// 【产检记录ID】
		/// </summary>
		public long ArchiveRecordID {get;set;}


		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public long? ArchiveID {get;set;}
		/// <summary>
		/// 【产检档案ID】
		/// </summary>
		public virtual ArchivesDto Archives {get;set;}


		/// <summary>
		/// 【站点ID】
		/// </summary>
		public int? SiteID {get;set;}


		/// <summary>
		/// 【MD5验证值】
		/// </summary>
		public string MD5Valid {get;set;}


		/// <summary>
		/// 【产检记录编号】
		/// </summary>
		public string ArchiveRecordNo {get;set;}


		/// <summary>
		/// 【医院编号】
		/// </summary>
		public string HospitalNo {get;set;}


		/// <summary>
		/// 【日期】
		/// </summary>
		public DateTime? ArchiveDate {get;set;}


		/// <summary>
		/// 【孕周】怀孕周数
		/// </summary>
		public int? ArchiveWeeks {get;set;}


		/// <summary>
		/// 【孕天】怀孕第几周又几天
		/// </summary>
		public int? ArchiveDays {get;set;}


		/// <summary>
		/// 【收缩压】
		/// </summary>
		public decimal? Systolic {get;set;}


		/// <summary>
		/// 【舒张压】
		/// </summary>
		public decimal? Diastolic {get;set;}


		/// <summary>
		/// 【体重】
		/// </summary>
		public decimal? BodyWeight {get;set;}


		/// <summary>
		/// 【宫高】
		/// </summary>
		public decimal? FundalHeight {get;set;}


		/// <summary>
		/// 【腹围】
		/// </summary>
		public decimal? AbdominalCircumference {get;set;}


		/// <summary>
		/// 【胎位】顶先露六种胎位的英文缩写：
		///             
		///             左枕前（LOA） 左枕横（LOT） 左枕后（LOP） 右枕前（ROA） 右枕横（ROT） 右枕后（ROP）
		///             
		///             臀先露六种胎位的英文缩写：
		///             
		///             左骶前（LSA） 左骶横（LST） 左骶后（LSP） 右骶前（RSA） 右骶横（RST） 右骶后（RSP）
		///             
		///             面先露六种胎位的英文缩写：
		///             
		///             左颏前（LMA） 左颏横（LMT） 左颏后（LMP） 右颏前（RMA） 右颏横（RMT） 右颏后（RMP）
		///             
		///             肩先露四种胎位的英文缩写：
		///             左肩前（LScA） 左肩后（LScP） 右肩前（RScA） 右肩后
		///             
		///             [101，LOA 
		///             102，LOT 
		///             103，LOP 
		///             104，ROA 
		///             105，ROT 
		///             106，ROP
		///             201，LSA 
		///             202，LST 
		///             203，LSP 
		///             204，RSA 
		///             205，RST 
		///             206，RSP
		///             301，LMA 
		///             302，LMT 
		///             303，LMP 
		///             304，RMA 
		///             305，RMT 
		///             306，RMP
		///             401，LScA 
		///             402，LScP 
		///             403，RScA 
		///             404，RScP]
		/// </summary>
		public FetalPositionEnum? FetalPosition {get;set;}


		/// <summary>
		/// 【胎位值】
		/// </summary>
		public string FetalPositionVal {get;set;}


		/// <summary>
		/// 【胎心】
		/// </summary>
		public decimal? FetalHeart {get;set;}


		/// <summary>
		/// 【胎先露】
		/// </summary>
		public byte? IsFetalPresentation {get;set;}


		/// <summary>
		/// 【衔接】
		/// </summary>
		public byte? IsEngagement {get;set;}


		/// <summary>
		/// 【胎动】
		/// </summary>
		public int? FetalMovement {get;set;}


		/// <summary>
		/// 【浮肿】
		/// </summary>
		public byte? IsEdema {get;set;}


		/// <summary>
		/// 【辅助检查项目】
		/// </summary>
		public string AuxiliaryInspection {get;set;}


		/// <summary>
		/// 【辅助检查重点指标】
		/// </summary>
		public string KeyIndicators {get;set;}


		/// <summary>
		/// 【是否有异常】
		/// </summary>
		public byte? IsAbnormal {get;set;}


		/// <summary>
		/// 【总体评估】
		/// </summary>
		public string Diagnosis {get;set;}


		/// <summary>
		/// 【异常情况处理】
		/// </summary>
		public string Abnormal {get;set;}


		/// <summary>
		/// 【妊娠风险评估】1. 绿（低风险）、
		///             2. 黄（一般风险）、
		///             3. 橙（较高风险）、
		///             4. 红（高风险）、
		///             5. 紫（传染病）
		///             [1，绿
		///             2，黄
		///             3，橙
		///             4，红
		///             5，紫]
		/// </summary>
		public RiskLevelEnum? RiskLevel {get;set;}


		/// <summary>
		/// 【妊娠风险评估】
		/// </summary>
		public string Risk {get;set;}


		/// <summary>
		/// 【卫生指导】
		/// </summary>
		public string HealthGuidance {get;set;}


		/// <summary>
		/// 【检查医院】
		/// </summary>
		public string Hospital {get;set;}


		/// <summary>
		/// 【医生】
		/// </summary>
		public string DoctorName {get;set;}


		/// <summary>
		/// 【下次随诊时间】
		/// </summary>
		public DateTime? NextCheckDate {get;set;}


		/// <summary>
		/// 【产检通知状态】[0，未通知
		///             1，到期通知
		///             2，当天通知
		///             3，过期通知
		///             ]
		/// </summary>
		public NoticStatusEnum? NoticStatus {get;set;}


		/// <summary>
		/// 【通知时间】
		/// </summary>
		public DateTime? NoticDateTime {get;set;}


		/// <summary>
		/// 【下次随嘱托】
		/// </summary>
		public string NextCheckEntrust {get;set;}


		/// <summary>
		/// 【是否转诊】
		/// </summary>
		public byte? IsChangeHospital {get;set;}


		/// <summary>
		/// 【转诊医院】
		/// </summary>
		public string ChangeHospital {get;set;}


		/// <summary>
		/// 【是否完成接诊】
		/// </summary>
		public byte? IsOver {get;set;}


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
