using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【交易状态】[0，失败
	/// 10，成功
	/// 20，订单不存在
	/// 30，金额不匹配]
	/// </summary>
	public enum TransStatusEnum:byte
	{
		/// <summary>
		/// 名称：失败，值：0
		/// </summary>
		[DisplayName("失败")]
		失败 = 0,

		/// <summary>
		/// 名称：成功，值：10
		/// </summary>
		[DisplayName("成功")]
		成功 = 10,

		/// <summary>
		/// 名称：订单不存在，值：20
		/// </summary>
		[DisplayName("订单不存在")]
		订单不存在 = 20,

		/// <summary>
		/// 名称：金额不匹配，值：30
		/// </summary>
		[DisplayName("金额不匹配")]
		金额不匹配 = 30,


	}
}
