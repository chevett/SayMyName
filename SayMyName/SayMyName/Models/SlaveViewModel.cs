using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SayMyName.Models
{
	public class SlaveViewModel
	{
		public string Description 
		{ 
			get
			{
				string desc;
				return DescriptionLookup.TryGetValue(IpAddress, out desc) ? desc : "unknown slave";
			}
		}

		public string IpAddress { get; set; }
		public string CurrentLocation { get; set; }
		public string Fingerprint { get; set; }

		private static readonly Dictionary<string, string> DescriptionLookup = new Dictionary<string, string>(); // hey bozo, put this in a file er something. 
	}
}