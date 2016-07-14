using System;
using System.ServiceModel;
using System.Text;

namespace Client
{
	class ServiceProxy
	{
		[ServiceContract(Namespace = "http://indigo300.rssing.com/chan-7039254/all_p1.html")]
		public interface IHelloIndigoService
		{
			[OperationContract]
			string HelloIndigo();
		}
	}
}
