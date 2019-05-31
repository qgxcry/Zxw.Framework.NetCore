using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【状态】[0，失败
	///             1，成功]
	/// </summary>
	public enum StatusEnum
	{
		/// <summary>
		/// 名称：失败，值：0
		/// </summary>
		[DisplayName("失败")]
		失败 = 0,

		/// <summary>
		/// 名称：成功，值：1
		/// </summary>
		[DisplayName("成功")]
		成功 = 1,


	}
}
