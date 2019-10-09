
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Nexawo.Application.Referral
{
	public class Service1ReferralViewModel
	{
		[Key]
		[ScaffoldColumn(true)]
		public int Id {get;set;}
		[MaxLength(50),MinLength(4)]
		[Required]
		public string ForeName {get;set;}

		[MaxLength(50),MinLength(4)]
		[Required]
		public string SurName {get;set;}

		
		public DateTime DOB {get;set;}

		[MaxLength(50),MinLength(0)]
		public string Nationality {get;set;}

		
		public DateTime ReferralDate {get;set;}

		[MaxLength(50),MinLength(0)]
		public string ReferralSource {get;set;}

	}
}
