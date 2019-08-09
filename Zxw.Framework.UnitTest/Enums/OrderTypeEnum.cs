using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【订单类型】[0，预约挂号
	///             1，诊间支付
	///             2，咨询]
	/// </summary>
	public enum OrderTypeEnum:{ValType}
	{
		/// <summary>
		/// 名称：预约挂号，值：0
		/// </summary>
		[DisplayName("预约挂号")]
		预约挂号 = 0,

		/// <summary>
		/// 名称：诊间支付，值：1
		/// </summary>
		[DisplayName("诊间支付")]
		诊间支付 = 1,

		/// <summary>
		/// 名称：咨询，值：2
		/// </summary>
		[DisplayName("咨询")]
		咨询 = 2,


	}
}
