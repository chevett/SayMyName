using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SayMyName.Core
{
	public class SlaveHub : Hub
	{
		
	}

	public enum SlaveCommand
	{
		Redirect = 0,
		Register = 1,
	}

}