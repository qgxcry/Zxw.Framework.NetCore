using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【消息类型】[-1，Unknown
	///             0，Text
	///             1，Location
	///             2，Image
	///             3，Voice
	///             4，Video
	///             5，Link
	///             6，ShortVideo
	///             7，Event
	///             8，File
	///             999，NeuChar
	///             ]
	/// </summary>
	public enum MsgTypeEnum:byte
	{
		/// <summary>
		/// 名称：Unknown，值：1
		/// </summary>
		[DisplayName("Unknown")]
		Unknown = 1,

		/// <summary>
		/// 名称：Text，值：0
		/// </summary>
		[DisplayName("Text")]
		Text = 0,

		/// <summary>
		/// 名称：Location，值：1
		/// </summary>
		[DisplayName("Location")]
		Location = 1,

		/// <summary>
		/// 名称：Image，值：2
		/// </summary>
		[DisplayName("Image")]
		Image = 2,

		/// <summary>
		/// 名称：Voice，值：3
		/// </summary>
		[DisplayName("Voice")]
		Voice = 3,

		/// <summary>
		/// 名称：Video，值：4
		/// </summary>
		[DisplayName("Video")]
		Video = 4,

		/// <summary>
		/// 名称：Link，值：5
		/// </summary>
		[DisplayName("Link")]
		Link = 5,

		/// <summary>
		/// 名称：ShortVideo，值：6
		/// </summary>
		[DisplayName("ShortVideo")]
		ShortVideo = 6,

		/// <summary>
		/// 名称：Event，值：7
		/// </summary>
		[DisplayName("Event")]
		Event = 7,

		/// <summary>
		/// 名称：File，值：8
		/// </summary>
		[DisplayName("File")]
		File = 8,

		/// <summary>
		/// 名称：NeuChar，值：999
		/// </summary>
		[DisplayName("NeuChar")]
		NeuChar = 999,



	}
}
