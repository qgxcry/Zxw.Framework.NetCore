using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【接触物理性有害因素】[0，无
	///             1，噪声
	///             2，震动
	///             3，X射线
	///             4，电磁辐射
	///             5，高温
	///             6，极低温度
	///             7，微波
	///             8，其他]
	/// </summary>
	public enum PhysicalHarmfulsEnum:string
	{
		/// <summary>
		/// 名称：无，值：0
		/// </summary>
		[DisplayName("无")]
		无 = 0,

		/// <summary>
		/// 名称：噪声，值：1
		/// </summary>
		[DisplayName("噪声")]
		噪声 = 1,

		/// <summary>
		/// 名称：震动，值：2
		/// </summary>
		[DisplayName("震动")]
		震动 = 2,

		/// <summary>
		/// 名称：X射线，值：3
		/// </summary>
		[DisplayName("X射线")]
		X射线 = 3,

		/// <summary>
		/// 名称：电磁辐射，值：4
		/// </summary>
		[DisplayName("电磁辐射")]
		电磁辐射 = 4,

		/// <summary>
		/// 名称：高温，值：5
		/// </summary>
		[DisplayName("高温")]
		高温 = 5,

		/// <summary>
		/// 名称：极低温度，值：6
		/// </summary>
		[DisplayName("极低温度")]
		极低温度 = 6,

		/// <summary>
		/// 名称：微波，值：7
		/// </summary>
		[DisplayName("微波")]
		微波 = 7,

		/// <summary>
		/// 名称：其他，值：8
		/// </summary>
		[DisplayName("其他")]
		其他 = 8,


	}
}
