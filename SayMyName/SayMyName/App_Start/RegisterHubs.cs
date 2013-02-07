using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

[assembly: PreApplicationStartMethod(typeof(SayMyName.App_Start.RegisterHubs), "Start")]

namespace SayMyName.App_Start
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
