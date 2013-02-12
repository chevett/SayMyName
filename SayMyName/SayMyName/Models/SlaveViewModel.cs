using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SayMyName.Models
{
	public class SlaveViewModel
	{
		[Required]
		public string Description { get; set; }

		//[Required] bring this back with a custom binder
		public string IpAddress { get; set; }

		[Required]
		public string Location { get; set; }

		[Required]
		public string Fingerprint { get; set; }
	}
}