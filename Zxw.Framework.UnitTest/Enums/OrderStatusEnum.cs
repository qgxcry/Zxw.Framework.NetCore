using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【订单状态】[0，未支付
	///             1，已支付
	///             2，已取消
	///             3，支付失败]
	/// </summary>
	public enum OrderStatusEnum:{ValType}
	{
		/// <summary>
		/// 名称：未支付，值：0
		/// </summary>
		[DisplayName("未支付")]
		未支付 = 0,

		/// <summary>
		/// 名称：已支付，值：1
		/// </summary>
		[DisplayName("已支付")]
		已支付 = 1,

		/// <summary>
		/// 名称：已取消，值：2
		/// </summary>
		[DisplayName("已取消")]
		已取消 = 2,

		/// <summary>
		/// 名称：支付失败，值：3
		/// </summary>
		[DisplayName("支付失败")]
		支付失败 = 3,


	}
}
