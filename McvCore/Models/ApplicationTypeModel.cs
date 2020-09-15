using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace McvCore.Models
{
	public class ApplicationTypeModel
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
	}
}