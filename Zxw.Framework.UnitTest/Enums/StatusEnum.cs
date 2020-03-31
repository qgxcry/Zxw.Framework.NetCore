using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【Status】[0，未启用
	/// 1，正常
	/// 2，标题未初始化
	/// 3，暂停
	/// 4，无效]
	/// </summary>
	public enum StatusEnum:byte
	{
		/// <summary>
		/// 名称：未启用，值：0
		/// </summary>
		[DisplayName("未启用")]
		未启用 = 0,

		/// <summary>
		/// 名称：正常，值：1
		/// </summary>
		[DisplayName("正常")]
		正常 = 1,

		/// <summary>
		/// 名称：标题未初始化，值：2
		/// </summary>
		[DisplayName("标题未初始化")]
		标题未初始化 = 2,

		/// <summary>
		/// 名称：暂停，值：3
		/// </summary>
		[DisplayName("暂停")]
		暂停 = 3,

		/// <summary>
		/// 名称：无效，值：4
		/// </summary>
		[DisplayName("无效")]
		无效 = 4,


	}
}
