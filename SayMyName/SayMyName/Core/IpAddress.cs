using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StructureMap;

namespace SayMyName.Core
{
	public static class IpAddress
	{
		public static string Current()
		{
			var context = ObjectFactory.GetInstance<HttpContextBase>();
			if (context == null || context.Request == null)
				return null;

			var ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
			if (string.IsNullOrEmpty(ipAddress) || ipAddress.ToLower() == "unknown")
				ipAddress = context.Request.ServerVariables["REMOTE_ADDR"];

			return ipAddress;
		}
	}
}
