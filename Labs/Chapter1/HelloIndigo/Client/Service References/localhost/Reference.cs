﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.localhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://indigo300.rssing.com/chan-7039254/all_p1.html", ConfigurationName="localhost.IHelloIndigoService")]
    public interface IHelloIndigoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://indigo300.rssing.com/chan-7039254/all_p1.html/IHelloIndigoService/HelloInd" +
            "igo", ReplyAction="http://indigo300.rssing.com/chan-7039254/all_p1.html/IHelloIndigoService/HelloInd" +
            "igoResponse")]
        string HelloIndigo();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IHelloIndigoServiceChannel : Client.localhost.IHelloIndigoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class HelloIndigoServiceClient : System.ServiceModel.ClientBase<Client.localhost.IHelloIndigoService>, Client.localhost.IHelloIndigoService {
        
        public HelloIndigoServiceClient() {
        }
        
        public HelloIndigoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloIndigoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloIndigoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloIndigoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloIndigo() {
            return base.Channel.HelloIndigo();
        }
    }
}
