using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【既往史】[0，无
	///             1，贫血
	///             2，甲状腺疾病
	///             3，心脏病
	///             4，肝脏疾病
	///             5，高血压疾病
	///             6，肾脏疾病
	///             7，糖尿病
	///             8，结核病
	///             9，血压病
	///             10，精神病
	///             11，生殖器官畸形
	///             12，梅毒
	///             13，乙肝病毒携带
	///             14，HIV携带
	///             15，其他
	///             ]
	/// </summary>
	public enum PastHistoryEnum:string
	{
		/// <summary>
		/// 名称：无，值：0
		/// </summary>
		[DisplayName("无")]
		无 = 0,

		/// <summary>
		/// 名称：贫血，值：1
		/// </summary>
		[DisplayName("贫血")]
		贫血 = 1,

		/// <summary>
		/// 名称：甲状腺疾病，值：2
		/// </summary>
		[DisplayName("甲状腺疾病")]
		甲状腺疾病 = 2,

		/// <summary>
		/// 名称：心脏病，值：3
		/// </summary>
		[DisplayName("心脏病")]
		心脏病 = 3,

		/// <summary>
		/// 名称：肝脏疾病，值：4
		/// </summary>
		[DisplayName("肝脏疾病")]
		肝脏疾病 = 4,

		/// <summary>
		/// 名称：高血压疾病，值：5
		/// </summary>
		[DisplayName("高血压疾病")]
		高血压疾病 = 5,

		/// <summary>
		/// 名称：肾脏疾病，值：6
		/// </summary>
		[DisplayName("肾脏疾病")]
		肾脏疾病 = 6,

		/// <summary>
		/// 名称：糖尿病，值：7
		/// </summary>
		[DisplayName("糖尿病")]
		糖尿病 = 7,

		/// <summary>
		/// 名称：结核病，值：8
		/// </summary>
		[DisplayName("结核病")]
		结核病 = 8,

		/// <summary>
		/// 名称：血压病，值：9
		/// </summary>
		[DisplayName("血压病")]
		血压病 = 9,

		/// <summary>
		/// 名称：精神病，值：10
		/// </summary>
		[DisplayName("精神病")]
		精神病 = 10,

		/// <summary>
		/// 名称：生殖器官畸形，值：11
		/// </summary>
		[DisplayName("生殖器官畸形")]
		生殖器官畸形 = 11,

		/// <summary>
		/// 名称：梅毒，值：12
		/// </summary>
		[DisplayName("梅毒")]
		梅毒 = 12,

		/// <summary>
		/// 名称：乙肝病毒携带，值：13
		/// </summary>
		[DisplayName("乙肝病毒携带")]
		乙肝病毒携带 = 13,

		/// <summary>
		/// 名称：HIV携带，值：14
		/// </summary>
		[DisplayName("HIV携带")]
		HIV携带 = 14,

		/// <summary>
		/// 名称：其他，值：15
		/// </summary>
		[DisplayName("其他")]
		其他 = 15,



	}
}
