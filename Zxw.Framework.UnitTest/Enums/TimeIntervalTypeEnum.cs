using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【时段类型】[0，凌晨
	///             1，上午
	///             2，下午
	///             3，晚上]
	/// </summary>
	public enum TimeIntervalTypeEnum:{ValType}
	{
		/// <summary>
		/// 名称：凌晨，值：0
		/// </summary>
		[DisplayName("凌晨")]
		凌晨 = 0,

		/// <summary>
		/// 名称：上午，值：1
		/// </summary>
		[DisplayName("上午")]
		上午 = 1,

		/// <summary>
		/// 名称：下午，值：2
		/// </summary>
		[DisplayName("下午")]
		下午 = 2,

		/// <summary>
		/// 名称：晚上，值：3
		/// </summary>
		[DisplayName("晚上")]
		晚上 = 3,


	}
}
