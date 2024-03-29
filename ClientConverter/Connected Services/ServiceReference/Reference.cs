﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientConverter.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IConverter")]
    public interface IConverter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertMilesToKm", ReplyAction="http://tempuri.org/IConverter/ConvertMilesToKmResponse")]
        double ConvertMilesToKm(double miles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertMilesToKm", ReplyAction="http://tempuri.org/IConverter/ConvertMilesToKmResponse")]
        System.Threading.Tasks.Task<double> ConvertMilesToKmAsync(double miles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertFeetToMeters", ReplyAction="http://tempuri.org/IConverter/ConvertFeetToMetersResponse")]
        double ConvertFeetToMeters(double feet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertFeetToMeters", ReplyAction="http://tempuri.org/IConverter/ConvertFeetToMetersResponse")]
        System.Threading.Tasks.Task<double> ConvertFeetToMetersAsync(double feet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertInchesToCentimeters", ReplyAction="http://tempuri.org/IConverter/ConvertInchesToCentimetersResponse")]
        double ConvertInchesToCentimeters(double inches);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertInchesToCentimeters", ReplyAction="http://tempuri.org/IConverter/ConvertInchesToCentimetersResponse")]
        System.Threading.Tasks.Task<double> ConvertInchesToCentimetersAsync(double inches);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertPoundsToKilograms", ReplyAction="http://tempuri.org/IConverter/ConvertPoundsToKilogramsResponse")]
        double ConvertPoundsToKilograms(double pounds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConverter/ConvertPoundsToKilograms", ReplyAction="http://tempuri.org/IConverter/ConvertPoundsToKilogramsResponse")]
        System.Threading.Tasks.Task<double> ConvertPoundsToKilogramsAsync(double pounds);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConverterChannel : ServiceReference.IConverter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConverterClient : System.ServiceModel.ClientBase<ServiceReference.IConverter>, ServiceReference.IConverter {
        
        public ConverterClient() {
        }
        
        public ConverterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConverterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConverterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConverterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ConvertMilesToKm(double miles) {
            return base.Channel.ConvertMilesToKm(miles);
        }
        
        public System.Threading.Tasks.Task<double> ConvertMilesToKmAsync(double miles) {
            return base.Channel.ConvertMilesToKmAsync(miles);
        }
        
        public double ConvertFeetToMeters(double feet) {
            return base.Channel.ConvertFeetToMeters(feet);
        }
        
        public System.Threading.Tasks.Task<double> ConvertFeetToMetersAsync(double feet) {
            return base.Channel.ConvertFeetToMetersAsync(feet);
        }
        
        public double ConvertInchesToCentimeters(double inches) {
            return base.Channel.ConvertInchesToCentimeters(inches);
        }
        
        public System.Threading.Tasks.Task<double> ConvertInchesToCentimetersAsync(double inches) {
            return base.Channel.ConvertInchesToCentimetersAsync(inches);
        }
        
        public double ConvertPoundsToKilograms(double pounds) {
            return base.Channel.ConvertPoundsToKilograms(pounds);
        }
        
        public System.Threading.Tasks.Task<double> ConvertPoundsToKilogramsAsync(double pounds) {
            return base.Channel.ConvertPoundsToKilogramsAsync(pounds);
        }
    }
}
