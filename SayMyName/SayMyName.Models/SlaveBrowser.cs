using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallDataStore;

namespace SayMyName.Models
{
	public class SlaveBrowser : ISmallStorageItem
	{
		public string Fingerprint { get; set; }
		public List<string> IpAddress { get; set; }


		string ISmallStorageItem.GetKey()
		{
			throw new NotImplementedException();
		}
	}
}
