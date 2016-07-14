using System;
using System.ServiceModel;
using System.Text;

namespace HelloIndigo
{
	[ServiceContract(Namespace = "http://indigo300.rssing.com/chan-7039254/all_p1.html")]
	public interface IHelloIndigoService
	{
		[OperationContract]
		string HelloIndigo();
	}

	public class HelloIndigoService : IHelloIndigoService
	{
		public string HelloIndigo()
		{
			return "Hello Indigo";
		}
	}
}
