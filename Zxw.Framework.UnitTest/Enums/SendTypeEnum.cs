using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【发送类型】
	///             [0，短信+微信
	///             10，微信
	///             20，短信]
	/// </summary>
	public enum SendTypeEnum:byte
	{
		/// <summary>
		/// 名称：短信微信，值：0
		/// </summary>
		[DisplayName("短信+微信")]
		短信微信 = 0,

		/// <summary>
		/// 名称：微信，值：10
		/// </summary>
		[DisplayName("微信")]
		微信 = 10,

		/// <summary>
		/// 名称：短信，值：20
		/// </summary>
		[DisplayName("短信")]
		短信 = 20,


	}
}
