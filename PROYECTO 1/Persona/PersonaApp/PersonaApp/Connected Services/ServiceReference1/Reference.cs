﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonaApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="E_Persona", Namespace="http://schemas.datacontract.org/2004/07/Capa_Entidad")]
    [System.SerializableAttribute()]
    public partial class E_Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int codigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int edadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombresField;
        
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
        public string apellidos {
            get {
                return this.apellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.apellidosField, value) != true)) {
                    this.apellidosField = value;
                    this.RaisePropertyChanged("apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int codigo {
            get {
                return this.codigoField;
            }
            set {
                if ((this.codigoField.Equals(value) != true)) {
                    this.codigoField = value;
                    this.RaisePropertyChanged("codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int edad {
            get {
                return this.edadField;
            }
            set {
                if ((this.edadField.Equals(value) != true)) {
                    this.edadField = value;
                    this.RaisePropertyChanged("edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombres {
            get {
                return this.nombresField;
            }
            set {
                if ((object.ReferenceEquals(this.nombresField, value) != true)) {
                    this.nombresField = value;
                    this.RaisePropertyChanged("nombres");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="E_Respuesta", Namespace="http://schemas.datacontract.org/2004/07/Capa_Entidad")]
    [System.SerializableAttribute()]
    public partial class E_Respuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mensajeField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.mensajeField, value) != true)) {
                    this.mensajeField = value;
                    this.RaisePropertyChanged("mensaje");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarPersona", ReplyAction="http://tempuri.org/IService1/ListarPersonaResponse")]
        PersonaApp.ServiceReference1.E_Persona[] ListarPersona();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarPersona", ReplyAction="http://tempuri.org/IService1/ListarPersonaResponse")]
        System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Persona[]> ListarPersonaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarxId", ReplyAction="http://tempuri.org/IService1/ListarxIdResponse")]
        PersonaApp.ServiceReference1.E_Persona ListarxId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListarxId", ReplyAction="http://tempuri.org/IService1/ListarxIdResponse")]
        System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Persona> ListarxIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegistrarPersona", ReplyAction="http://tempuri.org/IService1/RegistrarPersonaResponse")]
        PersonaApp.ServiceReference1.E_Respuesta RegistrarPersona(PersonaApp.ServiceReference1.E_Persona p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RegistrarPersona", ReplyAction="http://tempuri.org/IService1/RegistrarPersonaResponse")]
        System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Respuesta> RegistrarPersonaAsync(PersonaApp.ServiceReference1.E_Persona p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarPersona", ReplyAction="http://tempuri.org/IService1/ActualizarPersonaResponse")]
        PersonaApp.ServiceReference1.E_Respuesta ActualizarPersona(PersonaApp.ServiceReference1.E_Persona p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarPersona", ReplyAction="http://tempuri.org/IService1/ActualizarPersonaResponse")]
        System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Respuesta> ActualizarPersonaAsync(PersonaApp.ServiceReference1.E_Persona p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarPersona", ReplyAction="http://tempuri.org/IService1/EliminarPersonaResponse")]
        PersonaApp.ServiceReference1.E_Respuesta EliminarPersona(PersonaApp.ServiceReference1.E_Persona p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarPersona", ReplyAction="http://tempuri.org/IService1/EliminarPersonaResponse")]
        System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Respuesta> EliminarPersonaAsync(PersonaApp.ServiceReference1.E_Persona p);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : PersonaApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<PersonaApp.ServiceReference1.IService1>, PersonaApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PersonaApp.ServiceReference1.E_Persona[] ListarPersona() {
            return base.Channel.ListarPersona();
        }
        
        public System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Persona[]> ListarPersonaAsync() {
            return base.Channel.ListarPersonaAsync();
        }
        
        public PersonaApp.ServiceReference1.E_Persona ListarxId(int id) {
            return base.Channel.ListarxId(id);
        }
        
        public System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Persona> ListarxIdAsync(int id) {
            return base.Channel.ListarxIdAsync(id);
        }
        
        public PersonaApp.ServiceReference1.E_Respuesta RegistrarPersona(PersonaApp.ServiceReference1.E_Persona p) {
            return base.Channel.RegistrarPersona(p);
        }
        
        public System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Respuesta> RegistrarPersonaAsync(PersonaApp.ServiceReference1.E_Persona p) {
            return base.Channel.RegistrarPersonaAsync(p);
        }
        
        public PersonaApp.ServiceReference1.E_Respuesta ActualizarPersona(PersonaApp.ServiceReference1.E_Persona p) {
            return base.Channel.ActualizarPersona(p);
        }
        
        public System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Respuesta> ActualizarPersonaAsync(PersonaApp.ServiceReference1.E_Persona p) {
            return base.Channel.ActualizarPersonaAsync(p);
        }
        
        public PersonaApp.ServiceReference1.E_Respuesta EliminarPersona(PersonaApp.ServiceReference1.E_Persona p) {
            return base.Channel.EliminarPersona(p);
        }
        
        public System.Threading.Tasks.Task<PersonaApp.ServiceReference1.E_Respuesta> EliminarPersonaAsync(PersonaApp.ServiceReference1.E_Persona p) {
            return base.Channel.EliminarPersonaAsync(p);
        }
    }
}
