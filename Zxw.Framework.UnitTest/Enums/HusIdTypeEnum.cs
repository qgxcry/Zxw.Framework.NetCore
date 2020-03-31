using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【丈夫证件类型】[1，身份证
	///             2，军官证
	///             4，护照]
	/// </summary>
	public enum HusIdTypeEnum:byte
	{
		/// <summary>
		/// 名称：身份证，值：1
		/// </summary>
		[DisplayName("身份证")]
		身份证 = 1,

		/// <summary>
		/// 名称：军官证，值：2
		/// </summary>
		[DisplayName("军官证")]
		军官证 = 2,

		/// <summary>
		/// 名称：护照，值：4
		/// </summary>
		[DisplayName("护照")]
		护照 = 4,


	}
}
