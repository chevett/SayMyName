using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SayMyName.Models
{
	public class SlaveViewModel
	{
		public string Description { get; set; }
		public string IpAddress { get; set; }
		public string CurrentLocation { get; set; }
		public string Fingerprint { get; set; }
	}
}