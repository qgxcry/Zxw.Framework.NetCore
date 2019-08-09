using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【产检通知状态】[0，未通知
	///             1，到期通知
	///             2，当天通知
	///             3，过期通知
	///             ]
	/// </summary>
	public enum NoticStatusEnum:{ValType}
	{
		/// <summary>
		/// 名称：未通知，值：0
		/// </summary>
		[DisplayName("未通知")]
		未通知 = 0,

		/// <summary>
		/// 名称：到期通知，值：1
		/// </summary>
		[DisplayName("到期通知")]
		到期通知 = 1,

		/// <summary>
		/// 名称：当天通知，值：2
		/// </summary>
		[DisplayName("当天通知")]
		当天通知 = 2,

		/// <summary>
		/// 名称：过期通知，值：3
		/// </summary>
		[DisplayName("过期通知")]
		过期通知 = 3,



	}
}
