﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_Chambix.ServicioDistrito {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DistritoBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Chambix")]
    [System.SerializableAttribute()]
    public partial class DistritoBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short idDistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreDistritoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short idDistrito {
            get {
                return this.idDistritoField;
            }
            set {
                if ((this.idDistritoField.Equals(value) != true)) {
                    this.idDistritoField = value;
                    this.RaisePropertyChanged("idDistrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombreDistrito {
            get {
                return this.nombreDistritoField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreDistritoField, value) != true)) {
                    this.nombreDistritoField = value;
                    this.RaisePropertyChanged("nombreDistrito");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioDistrito.IServicioDistrito")]
    public interface IServicioDistrito {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDistrito/GetAllDistritos", ReplyAction="http://tempuri.org/IServicioDistrito/GetAllDistritosResponse")]
        WEB_Chambix.ServicioDistrito.DistritoBE[] GetAllDistritos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDistrito/GetAllDistritos", ReplyAction="http://tempuri.org/IServicioDistrito/GetAllDistritosResponse")]
        System.Threading.Tasks.Task<WEB_Chambix.ServicioDistrito.DistritoBE[]> GetAllDistritosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioDistritoChannel : WEB_Chambix.ServicioDistrito.IServicioDistrito, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioDistritoClient : System.ServiceModel.ClientBase<WEB_Chambix.ServicioDistrito.IServicioDistrito>, WEB_Chambix.ServicioDistrito.IServicioDistrito {
        
        public ServicioDistritoClient() {
        }
        
        public ServicioDistritoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioDistritoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDistritoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDistritoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WEB_Chambix.ServicioDistrito.DistritoBE[] GetAllDistritos() {
            return base.Channel.GetAllDistritos();
        }
        
        public System.Threading.Tasks.Task<WEB_Chambix.ServicioDistrito.DistritoBE[]> GetAllDistritosAsync() {
            return base.Channel.GetAllDistritosAsync();
        }
    }
}