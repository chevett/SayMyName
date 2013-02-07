using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SayMyName.Core;
using StructureMap;

[assembly: PreApplicationStartMethod(typeof(SayMyName.App_Start.IocConfig), "Start")]

namespace SayMyName.App_Start
{
	public static class IocConfig
	{
		public static void Start()
		{
			ObjectFactory.Initialize(fact =>
				{
					fact.For<ISlaveMessagePublisher>()
					    .Singleton()
					    .Use<SlaveMessagePublisher>();

					fact.For<IMasterMessagePublisher>()
						.Singleton()
						.Use<MasterMessagePublisher>();
				});
		}
	}
}