using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【月经量】[1，多
	///             2，中
	///             3，少]
	/// </summary>
	public enum MenarcheBVEnum:byte
	{
		/// <summary>
		/// 名称：多，值：1
		/// </summary>
		[DisplayName("多")]
		多 = 1,

		/// <summary>
		/// 名称：中，值：2
		/// </summary>
		[DisplayName("中")]
		中 = 2,

		/// <summary>
		/// 名称：少，值：3
		/// </summary>
		[DisplayName("少")]
		少 = 3,


	}
}
