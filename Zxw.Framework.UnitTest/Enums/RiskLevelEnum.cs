using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【妊娠风险评估等级】1. 绿（低风险）、
	///             2. 黄（一般风险）、
	///             3. 橙（较高风险）、
	///             4. 红（高风险）、
	///             5. 紫（传染病）
	///             [1，绿
	///             2，黄
	///             3，橙
	///             4，红
	///             5，紫]
	/// </summary>
	public enum RiskLevelEnum:string
	{
		/// <summary>
		/// 名称：绿，值：1
		/// </summary>
		[DisplayName("绿")]
		绿 = 1,

		/// <summary>
		/// 名称：黄，值：2
		/// </summary>
		[DisplayName("黄")]
		黄 = 2,

		/// <summary>
		/// 名称：橙，值：3
		/// </summary>
		[DisplayName("橙")]
		橙 = 3,

		/// <summary>
		/// 名称：红，值：4
		/// </summary>
		[DisplayName("红")]
		红 = 4,

		/// <summary>
		/// 名称：紫，值：5
		/// </summary>
		[DisplayName("紫")]
		紫 = 5,


	}
}
