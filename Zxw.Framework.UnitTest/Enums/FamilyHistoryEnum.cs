using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【家族史】[0，无
	///             1，遗传性疾病
	///             2，发育畸形
	///             3，甲状腺疾病
	///             4，肿瘤
	///             5，精神疾病
	///             6，父母高血压
	///             7，父母糖尿病
	///             8，其他
	///             ]
	/// </summary>
	public enum FamilyHistoryEnum:string
	{
		/// <summary>
		/// 名称：无，值：0
		/// </summary>
		[DisplayName("无")]
		无 = 0,

		/// <summary>
		/// 名称：遗传性疾病，值：1
		/// </summary>
		[DisplayName("遗传性疾病")]
		遗传性疾病 = 1,

		/// <summary>
		/// 名称：发育畸形，值：2
		/// </summary>
		[DisplayName("发育畸形")]
		发育畸形 = 2,

		/// <summary>
		/// 名称：甲状腺疾病，值：3
		/// </summary>
		[DisplayName("甲状腺疾病")]
		甲状腺疾病 = 3,

		/// <summary>
		/// 名称：肿瘤，值：4
		/// </summary>
		[DisplayName("肿瘤")]
		肿瘤 = 4,

		/// <summary>
		/// 名称：精神疾病，值：5
		/// </summary>
		[DisplayName("精神疾病")]
		精神疾病 = 5,

		/// <summary>
		/// 名称：父母高血压，值：6
		/// </summary>
		[DisplayName("父母高血压")]
		父母高血压 = 6,

		/// <summary>
		/// 名称：父母糖尿病，值：7
		/// </summary>
		[DisplayName("父母糖尿病")]
		父母糖尿病 = 7,

		/// <summary>
		/// 名称：其他，值：8
		/// </summary>
		[DisplayName("其他")]
		其他 = 8,



	}
}
