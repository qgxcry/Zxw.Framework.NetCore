using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【职称】[0，无
	///             1，助理医师
	///             2，医师
	///             3，主治医师
	///             4，副主任医师
	///             5，主任医师
	///             ]
	/// </summary>
	public enum ProfessionalTitleEnum:byte
	{
		/// <summary>
		/// 名称：无，值：0
		/// </summary>
		[DisplayName("无")]
		无 = 0,

		/// <summary>
		/// 名称：助理医师，值：1
		/// </summary>
		[DisplayName("助理医师")]
		助理医师 = 1,

		/// <summary>
		/// 名称：医师，值：2
		/// </summary>
		[DisplayName("医师")]
		医师 = 2,

		/// <summary>
		/// 名称：主治医师，值：3
		/// </summary>
		[DisplayName("主治医师")]
		主治医师 = 3,

		/// <summary>
		/// 名称：副主任医师，值：4
		/// </summary>
		[DisplayName("副主任医师")]
		副主任医师 = 4,

		/// <summary>
		/// 名称：主任医师，值：5
		/// </summary>
		[DisplayName("主任医师")]
		主任医师 = 5,



	}
}
