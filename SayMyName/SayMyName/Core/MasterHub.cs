using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SayMyName.Models;
using StructureMap;

namespace SayMyName.Core
{
	public class MasterHub : Hub
	{
		public void SlaveConnected(string slaveFingerprint, string slaveLocation)
		{
			ObjectFactory.GetInstance<SlaveManager>().SlaveConnected(new SlaveViewModel
				{
					CurrentLocation =  slaveLocation,
					IpAddress = IpAddress.Current(),
					Fingerprint = slaveFingerprint,
				});
		}
	}
}