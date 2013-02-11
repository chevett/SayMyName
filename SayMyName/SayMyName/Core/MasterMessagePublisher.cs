using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SayMyName.Models;

namespace SayMyName.Core
{
	public class MasterMessagePublisher : MessagePublisher<MasterHub>, IMasterMessagePublisher
	{
		public void KnownSlaveConnected(SlaveViewModel slaveViewModel)
		{
			SendMessage(slaveViewModel, MasterMessageType.KnownSlaveConnected);
		}

		public void UnknownSlaveConnected(SlaveViewModel slaveViewModel)
		{
			SendMessage(slaveViewModel, MasterMessageType.UnknownSlaveConnected);
		}

		class MasterMessage
		{
			public string currentLocation, description, fingerprint, ipAddress;
			public MasterMessageType type;
		}

		private void SendMessage(SlaveViewModel slaveViewModel, MasterMessageType masterMessageType)
		{
			Context.Clients.All.commandReceived(CreateMessage(slaveViewModel, masterMessageType));
		}

		private MasterMessage CreateMessage(SlaveViewModel slaveViewModel, MasterMessageType masterMessageType)
		{
			return new MasterMessage
				{
					currentLocation = slaveViewModel.CurrentLocation,
					description = slaveViewModel.Description,
					fingerprint = slaveViewModel.Fingerprint,
					ipAddress = slaveViewModel.IpAddress,
					type = masterMessageType
				};
		}
	}

	public enum MasterMessageType
	{
		KnownSlaveConnected = 0,
		UnknownSlaveConnected = 1,
	}

	public interface IMasterMessagePublisher
	{
		void KnownSlaveConnected(SlaveViewModel slaveViewModel);
		void UnknownSlaveConnected(SlaveViewModel slaveViewModel);
	}
}