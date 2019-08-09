using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【联系人关系】[0，丈夫
	///             1，父母
	///             2，兄、弟、姊、妹
	///             3，其他]
	/// </summary>
	public enum ContactRelationshipEnum:{ValType}
	{
		/// <summary>
		/// 名称：丈夫，值：0
		/// </summary>
		[DisplayName("丈夫")]
		丈夫 = 0,

		/// <summary>
		/// 名称：父母，值：1
		/// </summary>
		[DisplayName("父母")]
		父母 = 1,

		/// <summary>
		/// 名称：兄弟姊妹，值：2
		/// </summary>
		[DisplayName("兄、弟、姊、妹")]
		兄弟姊妹 = 2,

		/// <summary>
		/// 名称：其他，值：3
		/// </summary>
		[DisplayName("其他")]
		其他 = 3,


	}
}
