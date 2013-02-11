using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SayMyName.Core
{
	public class SlaveMessagePublisher : MessagePublisher<SlaveHub>, ISlaveMessagePublisher
	{
		public void SendRedirectCommand(Uri url)
		{
			Context.Clients.All.commandReceived(new
			{
				command = SlaveCommand.Redirect,
				location = url.ToString(),
			});
		}

		public void SendRegisterCommand(string ipAddress)
		{
			// todo: make this only message the client with the matching ipAddress.

			Context.Clients.All.commandReceived(new
			{
				type = SlaveCommand.Register,
				location = Constants.RootUrl + "/register",
			});
		}
	}

	public interface ISlaveMessagePublisher
	{
		void SendRedirectCommand(Uri url);
		void SendRegisterCommand(string ipAddress);
	}
}