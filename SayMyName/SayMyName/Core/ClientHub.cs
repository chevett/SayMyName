using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SayMyName.Core
{
	public class ClientHub : Hub
	{
		public void ClientConnected(string fingerprint, string location)
		{
			Clients.All.commandReceived(new
				{
					type = ClientMessageType.Register,
					location = Constants.RootUrl + "/register",
					fingerprint,
				});
		}
	}

	public enum ClientMessageType
	{
		Redirect = 0,
		Register = 1,
	}

}