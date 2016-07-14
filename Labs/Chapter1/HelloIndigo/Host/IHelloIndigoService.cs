using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Host
{
	// NOTE: If you change the interface name "IHelloIndigoService" here, you must also update the reference to "IHelloIndigoService" in App.config.
	[ServiceContract(Namespace = "http://indigo300.rssing.com/chan-7039254/all_p1.html")]
	public interface IHelloIndigoService
	{
		[OperationContract]
		string HelloIndigo();
	}
}
