using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【接触高浓度工业毒物】[0，无
	///             1，重金属
	///             2，农药
	///             3，有机溶剂
	///             4，制药
	///             5，其他
	///             ]
	/// </summary>
	public enum IndustrialPoisonsEnum:string
	{
		/// <summary>
		/// 名称：无，值：0
		/// </summary>
		[DisplayName("无")]
		无 = 0,

		/// <summary>
		/// 名称：重金属，值：1
		/// </summary>
		[DisplayName("重金属")]
		重金属 = 1,

		/// <summary>
		/// 名称：农药，值：2
		/// </summary>
		[DisplayName("农药")]
		农药 = 2,

		/// <summary>
		/// 名称：有机溶剂，值：3
		/// </summary>
		[DisplayName("有机溶剂")]
		有机溶剂 = 3,

		/// <summary>
		/// 名称：制药，值：4
		/// </summary>
		[DisplayName("制药")]
		制药 = 4,

		/// <summary>
		/// 名称：其他，值：5
		/// </summary>
		[DisplayName("其他")]
		其他 = 5,



	}
}
