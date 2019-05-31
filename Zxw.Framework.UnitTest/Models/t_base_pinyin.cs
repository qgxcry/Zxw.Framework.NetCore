using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.EFCore;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 
	/// </summary>
	[Table("t_base_pinyin")]
	public partial class t_base_pinyin:BaseEntity
	{
		[Required]
		[MaxLength(255)]
		public string pin_yin_ {get;set;}


		[Key]
		public  int code_ {get;set;}



	}
}
