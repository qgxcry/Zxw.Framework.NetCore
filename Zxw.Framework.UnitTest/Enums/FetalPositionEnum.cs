using System;
using System.ComponentModel;

namespace ZLHP.Enums
{
	/// <summary>
	/// 【胎位】顶先露六种胎位的英文缩写：
	///             
	///             左枕前（LOA） 左枕横（LOT） 左枕后（LOP） 右枕前（ROA） 右枕横（ROT） 右枕后（ROP）
	///             
	///             臀先露六种胎位的英文缩写：
	///             
	///             左骶前（LSA） 左骶横（LST） 左骶后（LSP） 右骶前（RSA） 右骶横（RST） 右骶后（RSP）
	///             
	///             面先露六种胎位的英文缩写：
	///             
	///             左颏前（LMA） 左颏横（LMT） 左颏后（LMP） 右颏前（RMA） 右颏横（RMT） 右颏后（RMP）
	///             
	///             肩先露四种胎位的英文缩写：
	///             左肩前（LScA） 左肩后（LScP） 右肩前（RScA） 右肩后
	///             
	///             [101，LOA 
	///             102，LOT 
	///             103，LOP 
	///             104，ROA 
	///             105，ROT 
	///             106，ROP
	///             201，LSA 
	///             202，LST 
	///             203，LSP 
	///             204，RSA 
	///             205，RST 
	///             206，RSP
	///             301，LMA 
	///             302，LMT 
	///             303，LMP 
	///             304，RMA 
	///             305，RMT 
	///             306，RMP
	///             401，LScA 
	///             402，LScP 
	///             403，RScA 
	///             404，RScP]
	/// </summary>
	public enum FetalPositionEnum:{ValType}
	{
		/// <summary>
		/// 名称：LOA，值：101
		/// </summary>
		[DisplayName("LOA")]
		LOA = 101,

		/// <summary>
		/// 名称：LOT，值：102
		/// </summary>
		[DisplayName("LOT")]
		LOT = 102,

		/// <summary>
		/// 名称：LOP，值：103
		/// </summary>
		[DisplayName("LOP")]
		LOP = 103,

		/// <summary>
		/// 名称：ROA，值：104
		/// </summary>
		[DisplayName("ROA")]
		ROA = 104,

		/// <summary>
		/// 名称：ROT，值：105
		/// </summary>
		[DisplayName("ROT")]
		ROT = 105,

		/// <summary>
		/// 名称：ROP，值：106
		/// </summary>
		[DisplayName("ROP")]
		ROP = 106,

		/// <summary>
		/// 名称：LSA，值：201
		/// </summary>
		[DisplayName("LSA")]
		LSA = 201,

		/// <summary>
		/// 名称：LST，值：202
		/// </summary>
		[DisplayName("LST")]
		LST = 202,

		/// <summary>
		/// 名称：LSP，值：203
		/// </summary>
		[DisplayName("LSP")]
		LSP = 203,

		/// <summary>
		/// 名称：RSA，值：204
		/// </summary>
		[DisplayName("RSA")]
		RSA = 204,

		/// <summary>
		/// 名称：RST，值：205
		/// </summary>
		[DisplayName("RST")]
		RST = 205,

		/// <summary>
		/// 名称：RSP，值：206
		/// </summary>
		[DisplayName("RSP")]
		RSP = 206,

		/// <summary>
		/// 名称：LMA，值：301
		/// </summary>
		[DisplayName("LMA")]
		LMA = 301,

		/// <summary>
		/// 名称：LMT，值：302
		/// </summary>
		[DisplayName("LMT")]
		LMT = 302,

		/// <summary>
		/// 名称：LMP，值：303
		/// </summary>
		[DisplayName("LMP")]
		LMP = 303,

		/// <summary>
		/// 名称：RMA，值：304
		/// </summary>
		[DisplayName("RMA")]
		RMA = 304,

		/// <summary>
		/// 名称：RMT，值：305
		/// </summary>
		[DisplayName("RMT")]
		RMT = 305,

		/// <summary>
		/// 名称：RMP，值：306
		/// </summary>
		[DisplayName("RMP")]
		RMP = 306,

		/// <summary>
		/// 名称：LScA，值：401
		/// </summary>
		[DisplayName("LScA")]
		LScA = 401,

		/// <summary>
		/// 名称：LScP，值：402
		/// </summary>
		[DisplayName("LScP")]
		LScP = 402,

		/// <summary>
		/// 名称：RScA，值：403
		/// </summary>
		[DisplayName("RScA")]
		RScA = 403,

		/// <summary>
		/// 名称：RScP，值：404
		/// </summary>
		[DisplayName("RScP")]
		RScP = 404,


	}
}
