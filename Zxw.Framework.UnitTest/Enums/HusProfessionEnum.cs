using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【丈夫职业】[0，国家机关、党群组织、企业、事业单位负责人
	///             1，专业技术人员 
	///             2，办事人员和有关人员
	///             3，商业、服务业人员
	///             4，农、林、牧、渔、水利业生产人员
	///             5，生产、运输设备操作人员及有关人员
	///             6，军人
	///             7，不便分类的其他从业人员
	///             8，无职业
	///             ]
	/// </summary>
	public enum HusProfessionEnum:{ValType}
	{
		/// <summary>
		/// 名称：国家机关党群组织企业事业单位负责人，值：0
		/// </summary>
		[DisplayName("国家机关、党群组织、企业、事业单位负责人")]
		国家机关党群组织企业事业单位负责人 = 0,

		/// <summary>
		/// 名称：专业技术人员，值：1
		/// </summary>
		[DisplayName("专业技术人员")]
		专业技术人员 = 1,

		/// <summary>
		/// 名称：办事人员和有关人员，值：2
		/// </summary>
		[DisplayName("办事人员和有关人员")]
		办事人员和有关人员 = 2,

		/// <summary>
		/// 名称：商业服务业人员，值：3
		/// </summary>
		[DisplayName("商业、服务业人员")]
		商业服务业人员 = 3,

		/// <summary>
		/// 名称：农林牧渔水利业生产人员，值：4
		/// </summary>
		[DisplayName("农、林、牧、渔、水利业生产人员")]
		农林牧渔水利业生产人员 = 4,

		/// <summary>
		/// 名称：生产运输设备操作人员及有关人员，值：5
		/// </summary>
		[DisplayName("生产、运输设备操作人员及有关人员")]
		生产运输设备操作人员及有关人员 = 5,

		/// <summary>
		/// 名称：军人，值：6
		/// </summary>
		[DisplayName("军人")]
		军人 = 6,

		/// <summary>
		/// 名称：不便分类的其他从业人员，值：7
		/// </summary>
		[DisplayName("不便分类的其他从业人员")]
		不便分类的其他从业人员 = 7,

		/// <summary>
		/// 名称：无职业，值：8
		/// </summary>
		[DisplayName("无职业")]
		无职业 = 8,



	}
}
