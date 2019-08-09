using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【婚姻状况】[1，未婚
	///             2，已婚
	///             3，丧偶
	///             4，离婚
	///             5，未说明的婚姻状况]
	/// </summary>
	public enum MaritalStatusEnum:{ValType}
	{
		/// <summary>
		/// 名称：未婚，值：1
		/// </summary>
		[DisplayName("未婚")]
		未婚 = 1,

		/// <summary>
		/// 名称：已婚，值：2
		/// </summary>
		[DisplayName("已婚")]
		已婚 = 2,

		/// <summary>
		/// 名称：丧偶，值：3
		/// </summary>
		[DisplayName("丧偶")]
		丧偶 = 3,

		/// <summary>
		/// 名称：离婚，值：4
		/// </summary>
		[DisplayName("离婚")]
		离婚 = 4,

		/// <summary>
		/// 名称：未说明的婚姻状况，值：5
		/// </summary>
		[DisplayName("未说明的婚姻状况")]
		未说明的婚姻状况 = 5,


	}
}
