using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【丈夫血型ABO】[1，B型
	///             2，O型
	///             3，A型
	///             4，AB型
	///             5，不详]
	/// </summary>
	public enum HusBloodABOEnum:{ValType}
	{
		/// <summary>
		/// 名称：B型，值：1
		/// </summary>
		[DisplayName("B型")]
		B型 = 1,

		/// <summary>
		/// 名称：O型，值：2
		/// </summary>
		[DisplayName("O型")]
		O型 = 2,

		/// <summary>
		/// 名称：A型，值：3
		/// </summary>
		[DisplayName("A型")]
		A型 = 3,

		/// <summary>
		/// 名称：AB型，值：4
		/// </summary>
		[DisplayName("AB型")]
		AB型 = 4,

		/// <summary>
		/// 名称：不详，值：5
		/// </summary>
		[DisplayName("不详")]
		不详 = 5,


	}
}
