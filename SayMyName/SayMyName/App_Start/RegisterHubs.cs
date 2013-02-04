using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

[assembly: PreApplicationStartMethod(typeof(SayMyName.RegisterHubs), "Start")]

namespace SayMyName
{
	public static class RegisterHubs
	{
		public static void Start()
		{
			// Register the default hubs route: ~/signalr/hubs
			RouteTable.Routes.MapHubs();
		}
	}
}
