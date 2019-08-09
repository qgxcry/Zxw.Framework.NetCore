using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【孕检状态】[0，已建档
	///             1，孕检中
	///             2，已分娩
	///             3，已结案
	///             ]
	///             
	/// </summary>
	public enum ArchiveStatusEnum:{ValType}
	{
		/// <summary>
		/// 名称：已建档，值：0
		/// </summary>
		[DisplayName("已建档")]
		已建档 = 0,

		/// <summary>
		/// 名称：孕检中，值：1
		/// </summary>
		[DisplayName("孕检中")]
		孕检中 = 1,

		/// <summary>
		/// 名称：已分娩，值：2
		/// </summary>
		[DisplayName("已分娩")]
		已分娩 = 2,

		/// <summary>
		/// 名称：已结案，值：3
		/// </summary>
		[DisplayName("已结案")]
		已结案 = 3,



	}
}
