﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopApplication.OrderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Services.Model")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApplication.OrderService.SalesLineItem[] SalesLineItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StatusField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DesktopApplication.OrderService.SalesLineItem[] SalesLineItems {
            get {
                return this.SalesLineItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesLineItemsField, value) != true)) {
                    this.SalesLineItemsField = value;
                    this.RaisePropertyChanged("SalesLineItems");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SalesLineItem", Namespace="http://schemas.datacontract.org/2004/07/Services.Model", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class SalesLineItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApplication.OrderService.Order OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApplication.OrderService.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DesktopApplication.OrderService.ProductVersion ProductVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int amountField;
        
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
        public DesktopApplication.OrderService.Order Order {
            get {
                return this.OrderField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderField, value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
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
        public DesktopApplication.OrderService.Product Product {
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
        public DesktopApplication.OrderService.ProductVersion ProductVersion {
            get {
                return this.ProductVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductVersionField, value) != true)) {
                    this.ProductVersionField = value;
                    this.RaisePropertyChanged("ProductVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
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
        private DesktopApplication.OrderService.ProductVersion[] ProductVersionsField;
        
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
        public DesktopApplication.OrderService.ProductVersion[] ProductVersions {
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
        private DesktopApplication.OrderService.Product ProductField;
        
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
        public DesktopApplication.OrderService.Product Product {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderService.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddOrder", ReplyAction="http://tempuri.org/IOrderService/AddOrderResponse")]
        int AddOrder(DesktopApplication.OrderService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddOrder", ReplyAction="http://tempuri.org/IOrderService/AddOrderResponse")]
        System.Threading.Tasks.Task<int> AddOrderAsync(DesktopApplication.OrderService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddSalesLineItemToOrder", ReplyAction="http://tempuri.org/IOrderService/AddSalesLineItemToOrderResponse")]
        bool AddSalesLineItemToOrder(DesktopApplication.OrderService.SalesLineItem[] sli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddSalesLineItemToOrder", ReplyAction="http://tempuri.org/IOrderService/AddSalesLineItemToOrderResponse")]
        System.Threading.Tasks.Task<bool> AddSalesLineItemToOrderAsync(DesktopApplication.OrderService.SalesLineItem[] sli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ChangeOrderToPaid", ReplyAction="http://tempuri.org/IOrderService/ChangeOrderToPaidResponse")]
        void ChangeOrderToPaid(DesktopApplication.OrderService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ChangeOrderToPaid", ReplyAction="http://tempuri.org/IOrderService/ChangeOrderToPaidResponse")]
        System.Threading.Tasks.Task ChangeOrderToPaidAsync(DesktopApplication.OrderService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrder", ReplyAction="http://tempuri.org/IOrderService/GetOrderResponse")]
        DesktopApplication.OrderService.Order GetOrder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrder", ReplyAction="http://tempuri.org/IOrderService/GetOrderResponse")]
        System.Threading.Tasks.Task<DesktopApplication.OrderService.Order> GetOrderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        DesktopApplication.OrderService.Order[] GetAllOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        System.Threading.Tasks.Task<DesktopApplication.OrderService.Order[]> GetAllOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetSalesLineItemsFromOrderID", ReplyAction="http://tempuri.org/IOrderService/GetSalesLineItemsFromOrderIDResponse")]
        DesktopApplication.OrderService.SalesLineItem[] GetSalesLineItemsFromOrderID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetSalesLineItemsFromOrderID", ReplyAction="http://tempuri.org/IOrderService/GetSalesLineItemsFromOrderIDResponse")]
        System.Threading.Tasks.Task<DesktopApplication.OrderService.SalesLineItem[]> GetSalesLineItemsFromOrderIDAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : DesktopApplication.OrderService.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<DesktopApplication.OrderService.IOrderService>, DesktopApplication.OrderService.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddOrder(DesktopApplication.OrderService.Order order) {
            return base.Channel.AddOrder(order);
        }
        
        public System.Threading.Tasks.Task<int> AddOrderAsync(DesktopApplication.OrderService.Order order) {
            return base.Channel.AddOrderAsync(order);
        }
        
        public bool AddSalesLineItemToOrder(DesktopApplication.OrderService.SalesLineItem[] sli) {
            return base.Channel.AddSalesLineItemToOrder(sli);
        }
        
        public System.Threading.Tasks.Task<bool> AddSalesLineItemToOrderAsync(DesktopApplication.OrderService.SalesLineItem[] sli) {
            return base.Channel.AddSalesLineItemToOrderAsync(sli);
        }
        
        public void ChangeOrderToPaid(DesktopApplication.OrderService.Order order) {
            base.Channel.ChangeOrderToPaid(order);
        }
        
        public System.Threading.Tasks.Task ChangeOrderToPaidAsync(DesktopApplication.OrderService.Order order) {
            return base.Channel.ChangeOrderToPaidAsync(order);
        }
        
        public DesktopApplication.OrderService.Order GetOrder(int id) {
            return base.Channel.GetOrder(id);
        }
        
        public System.Threading.Tasks.Task<DesktopApplication.OrderService.Order> GetOrderAsync(int id) {
            return base.Channel.GetOrderAsync(id);
        }
        
        public DesktopApplication.OrderService.Order[] GetAllOrders() {
            return base.Channel.GetAllOrders();
        }
        
        public System.Threading.Tasks.Task<DesktopApplication.OrderService.Order[]> GetAllOrdersAsync() {
            return base.Channel.GetAllOrdersAsync();
        }
        
        public DesktopApplication.OrderService.SalesLineItem[] GetSalesLineItemsFromOrderID(int id) {
            return base.Channel.GetSalesLineItemsFromOrderID(id);
        }
        
        public System.Threading.Tasks.Task<DesktopApplication.OrderService.SalesLineItem[]> GetSalesLineItemsFromOrderIDAsync(int id) {
            return base.Channel.GetSalesLineItemsFromOrderIDAsync(id);
        }
    }
}
