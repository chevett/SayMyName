using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SayMyName.Core
{
	// todo: is this a reasonable thing to do?  Seems crazy that i have to do this kind of thing myself.

	public abstract class MessagePublisher<THub>
			where THub : Hub
	{
		protected MessagePublisher()
		{
			Context = GlobalHost.ConnectionManager.GetHubContext<THub>();
		}

		protected IHubContext Context { get; private set; }
	}
}