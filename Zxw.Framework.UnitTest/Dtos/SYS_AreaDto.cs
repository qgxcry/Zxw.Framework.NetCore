using System;
using System.Collections.Generic;
using ZLHP.Enums;

namespace ZLHP.CheckReport.Contract.Dtos
{
	/// <summary>
	/// 【行政区域】
	/// </summary>
	public partial class SYS_AreaDto
	{
		/// <summary>
		/// 【区域ID】
		/// </summary>
		public int? AreaID {get;set;}


		/// <summary>
		/// 【父区域ID】
		/// </summary>
		public int? AreaPID {get;set;}


		/// <summary>
		/// 【区域名称】
		/// </summary>
		public string AreaName {get;set;}


		/// <summary>
		/// 【区域代码】
		/// </summary>
		public string AreaCode {get;set;}


		/// <summary>
		/// 【区域类型】1：>大区域（华北、华南、西北、西南等）
		///             2：>省份/直辖市
		///             3：>地级市
		///             4：>县级市/县
		/// </summary>
		public byte? AreaType {get;set;}


		/// <summary>
		/// 【是否禁用】
		/// </summary>
		public byte? IsEnabled {get;set;}


		/// <summary>
		/// 【创建时间】
		/// </summary>
		public DateTime? CreateTime {get;set;}


		/// <summary>
		/// 【是否热门】
		/// </summary>
		public byte? IsHot {get;set;}


		/// <summary>
		/// 【汉字拼音】
		/// </summary>
		public string LetterFirst {get;set;}


		/// <summary>
		/// 【简拼】
		/// </summary>
		public string JianPin {get;set;}


		/// <summary>
		/// 【拼音】
		/// </summary>
		public string PinYin {get;set;}


		/// <summary>
		/// 是否删除
		/// </summary>
		public byte? IsDeleted {get;set;}



	}
}
