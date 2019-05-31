using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【痛经】[0，无
	///             1，轻
	///             2，中
	///             3，重]
	/// </summary>
	public enum DysmenorrheaEnum
	{
		/// <summary>
		/// 名称：无，值：0
		/// </summary>
		[DisplayName("无")]
		无 = 0,

		/// <summary>
		/// 名称：轻，值：1
		/// </summary>
		[DisplayName("轻")]
		轻 = 1,

		/// <summary>
		/// 名称：中，值：2
		/// </summary>
		[DisplayName("中")]
		中 = 2,

		/// <summary>
		/// 名称：重，值：3
		/// </summary>
		[DisplayName("重")]
		重 = 3,


	}
}
