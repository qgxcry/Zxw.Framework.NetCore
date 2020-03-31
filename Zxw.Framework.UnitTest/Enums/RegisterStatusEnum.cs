using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【状态】[0，待支付
	///             1，已预约
	///             2，已取消]
	/// </summary>
	public enum RegisterStatusEnum:byte
	{
		/// <summary>
		/// 名称：待支付，值：0
		/// </summary>
		[DisplayName("待支付")]
		待支付 = 0,

		/// <summary>
		/// 名称：已预约，值：1
		/// </summary>
		[DisplayName("已预约")]
		已预约 = 1,

		/// <summary>
		/// 名称：已取消，值：2
		/// </summary>
		[DisplayName("已取消")]
		已取消 = 2,


	}
}
