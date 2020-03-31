using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【过敏源】[10，镇静麻醉剂
	///             20，动物毛发
	///             30，抗生素
	///             31，青霉素
	///             32，链霉素
	///             33，磺胺
	///             40，柑橘类水果
	///             50，室内灰尘
	///             60，鸡蛋
	///             70，鱼及贝壳类食
	///             80，碘
	///             90，牛奶
	///             100，带壳的果仁
	///             110，花粉
	///             999，其他]
	/// </summary>
	public enum AllergenEnum:string
	{
		/// <summary>
		/// 名称：镇静麻醉剂，值：10
		/// </summary>
		[DisplayName("镇静麻醉剂")]
		镇静麻醉剂 = 10,

		/// <summary>
		/// 名称：动物毛发，值：20
		/// </summary>
		[DisplayName("动物毛发")]
		动物毛发 = 20,

		/// <summary>
		/// 名称：抗生素，值：30
		/// </summary>
		[DisplayName("抗生素")]
		抗生素 = 30,

		/// <summary>
		/// 名称：青霉素，值：31
		/// </summary>
		[DisplayName("青霉素")]
		青霉素 = 31,

		/// <summary>
		/// 名称：链霉素，值：32
		/// </summary>
		[DisplayName("链霉素")]
		链霉素 = 32,

		/// <summary>
		/// 名称：磺胺，值：33
		/// </summary>
		[DisplayName("磺胺")]
		磺胺 = 33,

		/// <summary>
		/// 名称：柑橘类水果，值：40
		/// </summary>
		[DisplayName("柑橘类水果")]
		柑橘类水果 = 40,

		/// <summary>
		/// 名称：室内灰尘，值：50
		/// </summary>
		[DisplayName("室内灰尘")]
		室内灰尘 = 50,

		/// <summary>
		/// 名称：鸡蛋，值：60
		/// </summary>
		[DisplayName("鸡蛋")]
		鸡蛋 = 60,

		/// <summary>
		/// 名称：鱼及贝壳类食，值：70
		/// </summary>
		[DisplayName("鱼及贝壳类食")]
		鱼及贝壳类食 = 70,

		/// <summary>
		/// 名称：碘，值：80
		/// </summary>
		[DisplayName("碘")]
		碘 = 80,

		/// <summary>
		/// 名称：牛奶，值：90
		/// </summary>
		[DisplayName("牛奶")]
		牛奶 = 90,

		/// <summary>
		/// 名称：带壳的果仁，值：100
		/// </summary>
		[DisplayName("带壳的果仁")]
		带壳的果仁 = 100,

		/// <summary>
		/// 名称：花粉，值：110
		/// </summary>
		[DisplayName("花粉")]
		花粉 = 110,

		/// <summary>
		/// 名称：其他，值：999
		/// </summary>
		[DisplayName("其他")]
		其他 = 999,


	}
}
