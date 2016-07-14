using System;
using System.ServiceModel;

namespace Client
{
	class Program
	{
		static void Main(string[] args)
		{
			EndpointAddress ep = new EndpointAddress("http://localhost:8000/HelloIndigo/HelloIndigoService");
			
			// Create proxy.
			ServiceProxy.IHelloIndigoService proxy = ChannelFactory<ServiceProxy.IHelloIndigoService>.CreateChannel(
				new BasicHttpBinding(), ep);

			string s = proxy.HelloIndigo();
			Console.WriteLine(s);
			Console.WriteLine("Press <ENTER> to terminate the Client.");
			Console.ReadLine();
		}
	}
}
