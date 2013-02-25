using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallDataStore;

namespace SayMyName.Models
{
	public class SlavePage : ISmallStorageItem
	{
		public string Url { get; set; }

		string ISmallStorageItem.GetKey()
		{
			return Url.ToLowerInvariant();
		}

	}
}
