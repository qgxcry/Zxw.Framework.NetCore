using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZLHP.Enums;

namespace ZLHP.Site.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class t_base_pinyinViewModel
	{
		[Required]
		[MaxLength(255)]
		public string pin_yin_ {get;set;}


		[Required]
		public int code_ {get;set;}



	}
}
