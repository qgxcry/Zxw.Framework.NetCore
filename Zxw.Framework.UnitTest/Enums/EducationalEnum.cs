using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【文化程度】[0，研究生
	///             2，博士后
	///             3，博士
	///             4，硕士
	///             10，本科
	///             20，专科
	///             30，中专
	///             50，高中
	///             60，初中
	///             70，小学
	///             ]
	/// </summary>
	public enum EducationalEnum
	{
		/// <summary>
		/// 名称：研究生，值：0
		/// </summary>
		[DisplayName("研究生")]
		研究生 = 0,

		/// <summary>
		/// 名称：博士后，值：2
		/// </summary>
		[DisplayName("博士后")]
		博士后 = 2,

		/// <summary>
		/// 名称：博士，值：3
		/// </summary>
		[DisplayName("博士")]
		博士 = 3,

		/// <summary>
		/// 名称：硕士，值：4
		/// </summary>
		[DisplayName("硕士")]
		硕士 = 4,

		/// <summary>
		/// 名称：本科，值：10
		/// </summary>
		[DisplayName("本科")]
		本科 = 10,

		/// <summary>
		/// 名称：专科，值：20
		/// </summary>
		[DisplayName("专科")]
		专科 = 20,

		/// <summary>
		/// 名称：中专，值：30
		/// </summary>
		[DisplayName("中专")]
		中专 = 30,

		/// <summary>
		/// 名称：高中，值：50
		/// </summary>
		[DisplayName("高中")]
		高中 = 50,

		/// <summary>
		/// 名称：初中，值：60
		/// </summary>
		[DisplayName("初中")]
		初中 = 60,

		/// <summary>
		/// 名称：小学，值：70
		/// </summary>
		[DisplayName("小学")]
		小学 = 70,



	}
}
