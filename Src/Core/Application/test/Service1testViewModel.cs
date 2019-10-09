
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Nexawo.Application.test
{
	public class Service1testViewModel
	{
		[Key]
		[ScaffoldColumn(true)]
		public int Id {get;set;}
		[MaxLength(50),MinLength(1)]
		[Required]
		public string First {get; set;}

	}
}
