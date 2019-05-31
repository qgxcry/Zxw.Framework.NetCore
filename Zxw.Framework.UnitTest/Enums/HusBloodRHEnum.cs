using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【丈夫血型RH】[1，RH阳性
	///             2，RH阴性
	///             3，不详]
	/// </summary>
	public enum HusBloodRHEnum
	{
		/// <summary>
		/// 名称：RH阳性，值：1
		/// </summary>
		[DisplayName("RH阳性")]
		RH阳性 = 1,

		/// <summary>
		/// 名称：RH阴性，值：2
		/// </summary>
		[DisplayName("RH阴性")]
		RH阴性 = 2,

		/// <summary>
		/// 名称：不详，值：3
		/// </summary>
		[DisplayName("不详")]
		不详 = 3,


	}
}
