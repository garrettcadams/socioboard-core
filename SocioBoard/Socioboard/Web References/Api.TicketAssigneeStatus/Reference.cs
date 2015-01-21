﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18063.
// 
#pragma warning disable 1591

namespace Socioboard.Api.TicketAssigneeStatus {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TicketAssigneeStatusSoap", Namespace="http://tempuri.org/")]
    public partial class TicketAssigneeStatus : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddTicketAssigneeStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllAssignedMembersOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateAssigneeCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAssignedMembersOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TicketAssigneeStatus() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_TicketAssigneeStatus_TicketAssigneeStatus;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddTicketAssigneeStatusCompletedEventHandler AddTicketAssigneeStatusCompleted;
        
        /// <remarks/>
        public event getAllAssignedMembersCompletedEventHandler getAllAssignedMembersCompleted;
        
        /// <remarks/>
        public event updateAssigneeCountCompletedEventHandler updateAssigneeCountCompleted;
        
        /// <remarks/>
        public event getAssignedMembersCompletedEventHandler getAssignedMembersCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddTicketAssigneeStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddTicketAssigneeStatus(System.Guid AssignedUserId) {
            object[] results = this.Invoke("AddTicketAssigneeStatus", new object[] {
                        AssignedUserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddTicketAssigneeStatusAsync(System.Guid AssignedUserId) {
            this.AddTicketAssigneeStatusAsync(AssignedUserId, null);
        }
        
        /// <remarks/>
        public void AddTicketAssigneeStatusAsync(System.Guid AssignedUserId, object userState) {
            if ((this.AddTicketAssigneeStatusOperationCompleted == null)) {
                this.AddTicketAssigneeStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddTicketAssigneeStatusOperationCompleted);
            }
            this.InvokeAsync("AddTicketAssigneeStatus", new object[] {
                        AssignedUserId}, this.AddTicketAssigneeStatusOperationCompleted, userState);
        }
        
        private void OnAddTicketAssigneeStatusOperationCompleted(object arg) {
            if ((this.AddTicketAssigneeStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddTicketAssigneeStatusCompleted(this, new AddTicketAssigneeStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllAssignedMembers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllAssignedMembers() {
            object[] results = this.Invoke("getAllAssignedMembers", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllAssignedMembersAsync() {
            this.getAllAssignedMembersAsync(null);
        }
        
        /// <remarks/>
        public void getAllAssignedMembersAsync(object userState) {
            if ((this.getAllAssignedMembersOperationCompleted == null)) {
                this.getAllAssignedMembersOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllAssignedMembersOperationCompleted);
            }
            this.InvokeAsync("getAllAssignedMembers", new object[0], this.getAllAssignedMembersOperationCompleted, userState);
        }
        
        private void OngetAllAssignedMembersOperationCompleted(object arg) {
            if ((this.getAllAssignedMembersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllAssignedMembersCompleted(this, new getAllAssignedMembersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateAssigneeCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string updateAssigneeCount(string AssigneeUserId, int Count) {
            object[] results = this.Invoke("updateAssigneeCount", new object[] {
                        AssigneeUserId,
                        Count});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void updateAssigneeCountAsync(string AssigneeUserId, int Count) {
            this.updateAssigneeCountAsync(AssigneeUserId, Count, null);
        }
        
        /// <remarks/>
        public void updateAssigneeCountAsync(string AssigneeUserId, int Count, object userState) {
            if ((this.updateAssigneeCountOperationCompleted == null)) {
                this.updateAssigneeCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateAssigneeCountOperationCompleted);
            }
            this.InvokeAsync("updateAssigneeCount", new object[] {
                        AssigneeUserId,
                        Count}, this.updateAssigneeCountOperationCompleted, userState);
        }
        
        private void OnupdateAssigneeCountOperationCompleted(object arg) {
            if ((this.updateAssigneeCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateAssigneeCountCompleted(this, new updateAssigneeCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAssignedMembers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAssignedMembers(string AssigneeUserId) {
            object[] results = this.Invoke("getAssignedMembers", new object[] {
                        AssigneeUserId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAssignedMembersAsync(string AssigneeUserId) {
            this.getAssignedMembersAsync(AssigneeUserId, null);
        }
        
        /// <remarks/>
        public void getAssignedMembersAsync(string AssigneeUserId, object userState) {
            if ((this.getAssignedMembersOperationCompleted == null)) {
                this.getAssignedMembersOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAssignedMembersOperationCompleted);
            }
            this.InvokeAsync("getAssignedMembers", new object[] {
                        AssigneeUserId}, this.getAssignedMembersOperationCompleted, userState);
        }
        
        private void OngetAssignedMembersOperationCompleted(object arg) {
            if ((this.getAssignedMembersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAssignedMembersCompleted(this, new getAssignedMembersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddTicketAssigneeStatusCompletedEventHandler(object sender, AddTicketAssigneeStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddTicketAssigneeStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddTicketAssigneeStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getAllAssignedMembersCompletedEventHandler(object sender, getAllAssignedMembersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllAssignedMembersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllAssignedMembersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void updateAssigneeCountCompletedEventHandler(object sender, updateAssigneeCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateAssigneeCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateAssigneeCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getAssignedMembersCompletedEventHandler(object sender, getAssignedMembersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAssignedMembersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAssignedMembersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591