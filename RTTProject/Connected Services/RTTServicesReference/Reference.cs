﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTTProject.RTTServicesReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientDetails", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class ClientDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CellNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResidentialAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkNumberField;
        
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
        public string CellNumber {
            get {
                return this.CellNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CellNumberField, value) != true)) {
                    this.CellNumberField = value;
                    this.RaisePropertyChanged("CellNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResidentialAddress {
            get {
                return this.ResidentialAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.ResidentialAddressField, value) != true)) {
                    this.ResidentialAddressField = value;
                    this.RaisePropertyChanged("ResidentialAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkAddress {
            get {
                return this.WorkAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkAddressField, value) != true)) {
                    this.WorkAddressField = value;
                    this.RaisePropertyChanged("WorkAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkNumber {
            get {
                return this.WorkNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkNumberField, value) != true)) {
                    this.WorkNumberField = value;
                    this.RaisePropertyChanged("WorkNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientData", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary1")]
    [System.SerializableAttribute()]
    public partial class ClientData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.DataTable ClientTableField;
        
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
        public System.Data.DataTable ClientTable {
            get {
                return this.ClientTableField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientTableField, value) != true)) {
                    this.ClientTableField = value;
                    this.RaisePropertyChanged("ClientTable");
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

        internal void Delete(object customerId)
        {
            throw new NotImplementedException();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RTTServicesReference.IBusinessLogic")]
    public interface IBusinessLogic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessLogic/InsertUserDetails", ReplyAction="http://tempuri.org/IBusinessLogic/InsertUserDetailsResponse")]
        string InsertUserDetails(RTTProject.RTTServicesReference.ClientDetails value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessLogic/InsertUserDetails", ReplyAction="http://tempuri.org/IBusinessLogic/InsertUserDetailsResponse")]
        System.Threading.Tasks.Task<string> InsertUserDetailsAsync(RTTProject.RTTServicesReference.ClientDetails value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessLogic/DeleteDetails", ReplyAction="http://tempuri.org/IBusinessLogic/DeleteDetailsResponse")]
        int DeleteDetails(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessLogic/DeleteDetails", ReplyAction="http://tempuri.org/IBusinessLogic/DeleteDetailsResponse")]
        System.Threading.Tasks.Task<int> DeleteDetailsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessLogic/GetClientData", ReplyAction="http://tempuri.org/IBusinessLogic/GetClientDataResponse")]
        RTTProject.RTTServicesReference.ClientData GetClientData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusinessLogic/GetClientData", ReplyAction="http://tempuri.org/IBusinessLogic/GetClientDataResponse")]
        System.Threading.Tasks.Task<RTTProject.RTTServicesReference.ClientData> GetClientDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBusinessLogicChannel : RTTProject.RTTServicesReference.IBusinessLogic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BusinessLogicClient : System.ServiceModel.ClientBase<RTTProject.RTTServicesReference.IBusinessLogic>, RTTProject.RTTServicesReference.IBusinessLogic {
        
        public BusinessLogicClient() {
        }
        
        public BusinessLogicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BusinessLogicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusinessLogicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusinessLogicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertUserDetails(RTTProject.RTTServicesReference.ClientDetails value) {
            return base.Channel.InsertUserDetails(value);
        }
        
        public System.Threading.Tasks.Task<string> InsertUserDetailsAsync(RTTProject.RTTServicesReference.ClientDetails value) {
            return base.Channel.InsertUserDetailsAsync(value);
        }
        
        public int DeleteDetails(int id) {
            return base.Channel.DeleteDetails(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteDetailsAsync(int id) {
            return base.Channel.DeleteDetailsAsync(id);
        }
        
        public RTTProject.RTTServicesReference.ClientData GetClientData() {
            return base.Channel.GetClientData();
        }
        
        public System.Threading.Tasks.Task<RTTProject.RTTServicesReference.ClientData> GetClientDataAsync() {
            return base.Channel.GetClientDataAsync();
        }
    }
}
