using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【丈夫身体情况】[1，壮
	///             2，一般
	///             3，弱]
	/// </summary>
	public enum HusPhysicalConditionEnum:{ValType}
	{
		/// <summary>
		/// 名称：壮，值：1
		/// </summary>
		[DisplayName("壮")]
		壮 = 1,

		/// <summary>
		/// 名称：一般，值：2
		/// </summary>
		[DisplayName("一般")]
		一般 = 2,

		/// <summary>
		/// 名称：弱，值：3
		/// </summary>
		[DisplayName("弱")]
		弱 = 3,


	}
}
