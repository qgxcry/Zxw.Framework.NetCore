using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【退款类型】[0，全额
	///             1，部分]
	/// </summary>
	public enum RefundTypeEnum:{ValType}
	{
		/// <summary>
		/// 名称：全额，值：0
		/// </summary>
		[DisplayName("全额")]
		全额 = 0,

		/// <summary>
		/// 名称：部分，值：1
		/// </summary>
		[DisplayName("部分")]
		部分 = 1,


	}
}
