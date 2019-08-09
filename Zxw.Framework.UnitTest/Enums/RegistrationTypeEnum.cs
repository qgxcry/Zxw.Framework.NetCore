using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【预约类型】[1，当日
	///             2，预约]
	/// </summary>
	public enum RegistrationTypeEnum:{ValType}
	{
		/// <summary>
		/// 名称：当日，值：1
		/// </summary>
		[DisplayName("当日")]
		当日 = 1,

		/// <summary>
		/// 名称：预约，值：2
		/// </summary>
		[DisplayName("预约")]
		预约 = 2,


	}
}
