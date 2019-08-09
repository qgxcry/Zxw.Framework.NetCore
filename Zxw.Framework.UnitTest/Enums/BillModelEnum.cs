using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【支付类型】[0，微信
	///             1，支付宝
	///             2，其他]
	/// </summary>
	public enum BillModelEnum:{ValType}
	{
		/// <summary>
		/// 名称：微信，值：0
		/// </summary>
		[DisplayName("微信")]
		微信 = 0,

		/// <summary>
		/// 名称：支付宝，值：1
		/// </summary>
		[DisplayName("支付宝")]
		支付宝 = 1,

		/// <summary>
		/// 名称：其他，值：2
		/// </summary>
		[DisplayName("其他")]
		其他 = 2,


	}
}
