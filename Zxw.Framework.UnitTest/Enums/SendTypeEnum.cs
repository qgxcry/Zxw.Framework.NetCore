using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【消息发送类型】[0，微信
	///             1，短信]
	/// </summary>
	public enum SendTypeEnum
	{
		/// <summary>
		/// 名称：微信，值：0
		/// </summary>
		[DisplayName("微信")]
		微信 = 0,

		/// <summary>
		/// 名称：短信，值：1
		/// </summary>
		[DisplayName("短信")]
		短信 = 1,


	}
}
