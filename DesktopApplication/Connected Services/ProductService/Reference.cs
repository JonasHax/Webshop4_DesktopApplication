﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopApplication.ProductService {
    using System.Runtime.Serialization;
    using System;
    using DesktopApplication.Model;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApplication.ProductService.ProductVersion[] ProductVersionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StyleNumberField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApplication.ProductService.ProductVersion[] ProductVersions {
            get {
                return this.ProductVersionsField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductVersionsField, value) != true)) {
                    this.ProductVersionsField = value;
                    this.RaisePropertyChanged("ProductVersions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StyleNumber {
            get {
                return this.StyleNumberField;
            }
            set {
                if ((this.StyleNumberField.Equals(value) != true)) {
                    this.StyleNumberField = value;
                    this.RaisePropertyChanged("StyleNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductVersion", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    public partial class ProductVersion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApplication.ProductService.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SizeCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
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
        public string ColorCode {
            get {
                return this.ColorCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorCodeField, value) != true)) {
                    this.ColorCodeField = value;
                    this.RaisePropertyChanged("ColorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApplication.ProductService.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SizeCode {
            get {
                return this.SizeCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.SizeCodeField, value) != true)) {
                    this.SizeCodeField = value;
                    this.RaisePropertyChanged("SizeCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductService.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        DesktopApplication.ProductService.Product GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        System.Threading.Tasks.Task<DesktopApplication.ProductService.Product> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetANumber", ReplyAction="http://tempuri.org/IProductService/GetANumberResponse")]
        int GetANumber(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetANumber", ReplyAction="http://tempuri.org/IProductService/GetANumberResponse")]
        System.Threading.Tasks.Task<int> GetANumberAsync(int number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : DesktopApplication.ProductService.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<DesktopApplication.ProductService.IProductService>, DesktopApplication.ProductService.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DesktopApplication.ProductService.Product GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<DesktopApplication.ProductService.Product> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        public int GetANumber(int number) {
            return base.Channel.GetANumber(number);
        }
        
        public System.Threading.Tasks.Task<int> GetANumberAsync(int number) {
            return base.Channel.GetANumberAsync(number);
        }

        
    }
}
