using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SayMyName.Models;
using StructureMap;

namespace SayMyName.Core
{
	public class SlaveManager
	{
		private readonly Dictionary<string, SlaveInfo> _Dictionary = new Dictionary<string, SlaveInfo>(); // todo: save somewhere

		public bool IsRegistered(string ipAddress)
		{
			return _Dictionary.Keys.Contains(ipAddress);
		}

		public void RegisterSlave(SlaveViewModel slaveViewModel)
		{
			_Dictionary.Add(slaveViewModel.IpAddress, new SlaveInfo
				{
					IpAddress = slaveViewModel.IpAddress,
					Fingerprint = slaveViewModel.Fingerprint,
					LastKnownLocation = slaveViewModel.Location,
					RegistrationDateTime = DateTime.UtcNow,
					LastConnectDateTime = DateTime.UtcNow,
				});
		}

		public void SlaveConnected(SlaveViewModel slaveViewModel)
		{
			var masterMessagePublisher = ObjectFactory.GetInstance<IMasterMessagePublisher>();
			if (IsRegistered(slaveViewModel.IpAddress))
			{
				masterMessagePublisher.KnownSlaveConnected(slaveViewModel);
			}
			else
			{
				masterMessagePublisher.UnknownSlaveConnected(slaveViewModel);

				var slaveMessagePublisher = ObjectFactory.GetInstance<ISlaveMessagePublisher>();
				slaveMessagePublisher.SendRegisterCommand(slaveViewModel.IpAddress);
			}
		}

		class SlaveInfo
		{
			public string IpAddress { get; set; }
			public string Fingerprint { get; set; }
			public string LastKnownLocation { get; set; }
			public DateTime RegistrationDateTime { get; set; }
			public DateTime LastConnectDateTime { get; set; }
		}
	}
}