using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【二维码类型】[10，QR_SCENE
	///             20，QR_STR_SCENE
	///             30，QR_LIMIT_SCENE
	///             40，QR_LIMIT_STR_SCENE
	///             ]
	/// </summary>
	public enum ActionNameEnum:{ValType}
	{
		/// <summary>
		/// 名称：QR_SCENE，值：10
		/// </summary>
		[DisplayName("QR_SCENE")]
		QR_SCENE = 10,

		/// <summary>
		/// 名称：QR_STR_SCENE，值：20
		/// </summary>
		[DisplayName("QR_STR_SCENE")]
		QR_STR_SCENE = 20,

		/// <summary>
		/// 名称：QR_LIMIT_SCENE，值：30
		/// </summary>
		[DisplayName("QR_LIMIT_SCENE")]
		QR_LIMIT_SCENE = 30,

		/// <summary>
		/// 名称：QR_LIMIT_STR_SCENE，值：40
		/// </summary>
		[DisplayName("QR_LIMIT_STR_SCENE")]
		QR_LIMIT_STR_SCENE = 40,



	}
}
