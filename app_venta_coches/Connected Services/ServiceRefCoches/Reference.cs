﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app_venta_coches.ServiceRefCoches {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Coches", Namespace="http://schemas.datacontract.org/2004/07/WS_coches")]
    [System.SerializableAttribute()]
    public partial class Coches : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatriculaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PrecioField;
        
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
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Matricula {
            get {
                return this.MatriculaField;
            }
            set {
                if ((object.ReferenceEquals(this.MatriculaField, value) != true)) {
                    this.MatriculaField = value;
                    this.RaisePropertyChanged("Matricula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo {
            get {
                return this.ModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloField, value) != true)) {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRefCoches.IServiceCoches")]
    public interface IServiceCoches {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/agregarCoche", ReplyAction="http://tempuri.org/IServiceCoches/agregarCocheResponse")]
        int agregarCoche(app_venta_coches.ServiceRefCoches.Coches coche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/agregarCoche", ReplyAction="http://tempuri.org/IServiceCoches/agregarCocheResponse")]
        System.Threading.Tasks.Task<int> agregarCocheAsync(app_venta_coches.ServiceRefCoches.Coches coche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/editarCoche", ReplyAction="http://tempuri.org/IServiceCoches/editarCocheResponse")]
        int editarCoche(app_venta_coches.ServiceRefCoches.Coches coche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/editarCoche", ReplyAction="http://tempuri.org/IServiceCoches/editarCocheResponse")]
        System.Threading.Tasks.Task<int> editarCocheAsync(app_venta_coches.ServiceRefCoches.Coches coche);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/eliminarCoche", ReplyAction="http://tempuri.org/IServiceCoches/eliminarCocheResponse")]
        int eliminarCoche(string matricula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/eliminarCoche", ReplyAction="http://tempuri.org/IServiceCoches/eliminarCocheResponse")]
        System.Threading.Tasks.Task<int> eliminarCocheAsync(string matricula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/buscarCoche", ReplyAction="http://tempuri.org/IServiceCoches/buscarCocheResponse")]
        app_venta_coches.ServiceRefCoches.Coches buscarCoche(string matricula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/buscarCoche", ReplyAction="http://tempuri.org/IServiceCoches/buscarCocheResponse")]
        System.Threading.Tasks.Task<app_venta_coches.ServiceRefCoches.Coches> buscarCocheAsync(string matricula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/mostrarCoches", ReplyAction="http://tempuri.org/IServiceCoches/mostrarCochesResponse")]
        app_venta_coches.ServiceRefCoches.Coches[] mostrarCoches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCoches/mostrarCoches", ReplyAction="http://tempuri.org/IServiceCoches/mostrarCochesResponse")]
        System.Threading.Tasks.Task<app_venta_coches.ServiceRefCoches.Coches[]> mostrarCochesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCochesChannel : app_venta_coches.ServiceRefCoches.IServiceCoches, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCochesClient : System.ServiceModel.ClientBase<app_venta_coches.ServiceRefCoches.IServiceCoches>, app_venta_coches.ServiceRefCoches.IServiceCoches {
        
        public ServiceCochesClient() {
        }
        
        public ServiceCochesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCochesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCochesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCochesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int agregarCoche(app_venta_coches.ServiceRefCoches.Coches coche) {
            return base.Channel.agregarCoche(coche);
        }
        
        public System.Threading.Tasks.Task<int> agregarCocheAsync(app_venta_coches.ServiceRefCoches.Coches coche) {
            return base.Channel.agregarCocheAsync(coche);
        }
        
        public int editarCoche(app_venta_coches.ServiceRefCoches.Coches coche) {
            return base.Channel.editarCoche(coche);
        }
        
        public System.Threading.Tasks.Task<int> editarCocheAsync(app_venta_coches.ServiceRefCoches.Coches coche) {
            return base.Channel.editarCocheAsync(coche);
        }
        
        public int eliminarCoche(string matricula) {
            return base.Channel.eliminarCoche(matricula);
        }
        
        public System.Threading.Tasks.Task<int> eliminarCocheAsync(string matricula) {
            return base.Channel.eliminarCocheAsync(matricula);
        }
        
        public app_venta_coches.ServiceRefCoches.Coches buscarCoche(string matricula) {
            return base.Channel.buscarCoche(matricula);
        }
        
        public System.Threading.Tasks.Task<app_venta_coches.ServiceRefCoches.Coches> buscarCocheAsync(string matricula) {
            return base.Channel.buscarCocheAsync(matricula);
        }
        
        public app_venta_coches.ServiceRefCoches.Coches[] mostrarCoches() {
            return base.Channel.mostrarCoches();
        }
        
        public System.Threading.Tasks.Task<app_venta_coches.ServiceRefCoches.Coches[]> mostrarCochesAsync() {
            return base.Channel.mostrarCochesAsync();
        }
    }
}
