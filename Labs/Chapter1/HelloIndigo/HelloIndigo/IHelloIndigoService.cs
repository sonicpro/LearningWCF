using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloIndigo
{
	// NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in App.config.
	[ServiceContract(Namespace = "http://indigo300.rssing.com/chan-7039254/all_p1.html")]
	public interface IHelloIndigoService
	{
		[OperationContract]
		string HelloIndigo();
	}
}