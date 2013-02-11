using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SayMyName.Models;

namespace SayMyName.Core
{
	public class MasterMessagePublisher : MessagePublisher<MasterHub>, IMasterMessagePublisher
	{
		public void SlaveConnected(SlaveViewModel slaveViewModel)
		{
			Context.Clients.All.commandReceived(new {
				currentLocation = slaveViewModel.CurrentLocation,
				description = slaveViewModel.Description,
				fingerprint = slaveViewModel.Fingerprint,
				ipAddress = slaveViewModel.IpAddress,
				type = MasterMessageType.SlaveConnected
			});
		}



		

	}
	public enum MasterMessageType
	{
		SlaveConnected = 0,
	}
	public interface IMasterMessagePublisher
	{
		void SlaveConnected(SlaveViewModel slaveViewModel);
	}
}