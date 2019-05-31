using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【妇产科手术史】[0，无
	///             1，阴道手术
	///             2，宫颈锥切手术
	///             3，腹腔镜手术
	///             4，子宫肌瘤挖出手术
	///             5，子宫肌腺瘤挖出手术
	///             6，子宫整形术
	///             7，附件恶性肿瘤手术
	///             8，其他
	///             ]
	///             
	/// </summary>
	public enum SurgeryHistoryEnum
	{
		/// <summary>
		/// 名称：无，值：0
		/// </summary>
		[DisplayName("无")]
		无 = 0,

		/// <summary>
		/// 名称：阴道手术，值：1
		/// </summary>
		[DisplayName("阴道手术")]
		阴道手术 = 1,

		/// <summary>
		/// 名称：宫颈锥切手术，值：2
		/// </summary>
		[DisplayName("宫颈锥切手术")]
		宫颈锥切手术 = 2,

		/// <summary>
		/// 名称：腹腔镜手术，值：3
		/// </summary>
		[DisplayName("腹腔镜手术")]
		腹腔镜手术 = 3,

		/// <summary>
		/// 名称：子宫肌瘤挖出手术，值：4
		/// </summary>
		[DisplayName("子宫肌瘤挖出手术")]
		子宫肌瘤挖出手术 = 4,

		/// <summary>
		/// 名称：子宫肌腺瘤挖出手术，值：5
		/// </summary>
		[DisplayName("子宫肌腺瘤挖出手术")]
		子宫肌腺瘤挖出手术 = 5,

		/// <summary>
		/// 名称：子宫整形术，值：6
		/// </summary>
		[DisplayName("子宫整形术")]
		子宫整形术 = 6,

		/// <summary>
		/// 名称：附件恶性肿瘤手术，值：7
		/// </summary>
		[DisplayName("附件恶性肿瘤手术")]
		附件恶性肿瘤手术 = 7,

		/// <summary>
		/// 名称：其他，值：8
		/// </summary>
		[DisplayName("其他")]
		其他 = 8,



	}
}
