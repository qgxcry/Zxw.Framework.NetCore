using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【事件类型】[0，ENTER
	///             1，LOCATION
	///             2，subscribe
	///             3，unsubscribe
	///             4，CLICK
	///             5，scan
	///             6，VIEW
	///             7，MASSSENDJOBFINISH
	///             8，TEMPLATESENDJOBFINISH
	///             9，scancode_push
	///             10，scancode_waitmsg
	///             11，pic_sysphoto
	///             12，pic_photo_or_album
	///             13，pic_weixin
	///             14，location_select
	///             15，card_pass_check]
	/// </summary>
	public enum EventEnum:{ValType}
	{
		/// <summary>
		/// 名称：ENTER，值：0
		/// </summary>
		[DisplayName("ENTER")]
		ENTER = 0,

		/// <summary>
		/// 名称：LOCATION，值：1
		/// </summary>
		[DisplayName("LOCATION")]
		LOCATION = 1,

		/// <summary>
		/// 名称：subscribe，值：2
		/// </summary>
		[DisplayName("subscribe")]
		subscribe = 2,

		/// <summary>
		/// 名称：unsubscribe，值：3
		/// </summary>
		[DisplayName("unsubscribe")]
		unsubscribe = 3,

		/// <summary>
		/// 名称：CLICK，值：4
		/// </summary>
		[DisplayName("CLICK")]
		CLICK = 4,

		/// <summary>
		/// 名称：scan，值：5
		/// </summary>
		[DisplayName("scan")]
		scan = 5,

		/// <summary>
		/// 名称：VIEW，值：6
		/// </summary>
		[DisplayName("VIEW")]
		VIEW = 6,

		/// <summary>
		/// 名称：MASSSENDJOBFINISH，值：7
		/// </summary>
		[DisplayName("MASSSENDJOBFINISH")]
		MASSSENDJOBFINISH = 7,

		/// <summary>
		/// 名称：TEMPLATESENDJOBFINISH，值：8
		/// </summary>
		[DisplayName("TEMPLATESENDJOBFINISH")]
		TEMPLATESENDJOBFINISH = 8,

		/// <summary>
		/// 名称：scancode_push，值：9
		/// </summary>
		[DisplayName("scancode_push")]
		scancode_push = 9,

		/// <summary>
		/// 名称：scancode_waitmsg，值：10
		/// </summary>
		[DisplayName("scancode_waitmsg")]
		scancode_waitmsg = 10,

		/// <summary>
		/// 名称：pic_sysphoto，值：11
		/// </summary>
		[DisplayName("pic_sysphoto")]
		pic_sysphoto = 11,

		/// <summary>
		/// 名称：pic_photo_or_album，值：12
		/// </summary>
		[DisplayName("pic_photo_or_album")]
		pic_photo_or_album = 12,

		/// <summary>
		/// 名称：pic_weixin，值：13
		/// </summary>
		[DisplayName("pic_weixin")]
		pic_weixin = 13,

		/// <summary>
		/// 名称：location_select，值：14
		/// </summary>
		[DisplayName("location_select")]
		location_select = 14,

		/// <summary>
		/// 名称：card_pass_check，值：15
		/// </summary>
		[DisplayName("card_pass_check")]
		card_pass_check = 15,


	}
}
