﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileUpload.Utility.CacheFileUploadService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfErrorMessageErrorMessage", Namespace="http://tempuri.org", ItemName="ErrorMessage")]
    [System.SerializableAttribute()]
    public class ArrayOfErrorMessageErrorMessage : System.Collections.Generic.List<FileUpload.Utility.CacheFileUploadService.ErrorMessage> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorMessage", Namespace="http://tempuri.org")]
    [System.SerializableAttribute()]
    public partial class ErrorMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long RowStatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MessageText {
            get {
                return this.MessageTextField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageTextField, value) != true)) {
                    this.MessageTextField = value;
                    this.RaisePropertyChanged("MessageText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long RowStatus {
            get {
                return this.RowStatusField;
            }
            set {
                if ((this.RowStatusField.Equals(value) != true)) {
                    this.RowStatusField = value;
                    this.RaisePropertyChanged("RowStatus");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org", ConfigurationName="CacheFileUploadService.FileUploadServiceSoap")]
    public interface FileUploadServiceSoap {
        
        // CODEGEN: Generating message contract since element name FileName from namespace http://tempuri.org is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FUS.FileUploadService.ParseFile", ReplyAction="*")]
        FileUpload.Utility.CacheFileUploadService.ParseFileResponse ParseFile(FileUpload.Utility.CacheFileUploadService.ParseFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FUS.FileUploadService.ParseFile", ReplyAction="*")]
        System.Threading.Tasks.Task<FileUpload.Utility.CacheFileUploadService.ParseFileResponse> ParseFileAsync(FileUpload.Utility.CacheFileUploadService.ParseFileRequest request);
        
        // CODEGEN: Generating message contract since element name TestResult from namespace http://tempuri.org is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FUS.FileUploadService.Test", ReplyAction="*")]
        FileUpload.Utility.CacheFileUploadService.TestResponse Test(FileUpload.Utility.CacheFileUploadService.TestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FUS.FileUploadService.Test", ReplyAction="*")]
        System.Threading.Tasks.Task<FileUpload.Utility.CacheFileUploadService.TestResponse> TestAsync(FileUpload.Utility.CacheFileUploadService.TestRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ParseFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ParseFile", Namespace="http://tempuri.org", Order=0)]
        public FileUpload.Utility.CacheFileUploadService.ParseFileRequestBody Body;
        
        public ParseFileRequest() {
        }
        
        public ParseFileRequest(FileUpload.Utility.CacheFileUploadService.ParseFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org")]
    public partial class ParseFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FileName;
        
        public ParseFileRequestBody() {
        }
        
        public ParseFileRequestBody(string FileName) {
            this.FileName = FileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ParseFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ParseFileResponse", Namespace="http://tempuri.org", Order=0)]
        public FileUpload.Utility.CacheFileUploadService.ParseFileResponseBody Body;
        
        public ParseFileResponse() {
        }
        
        public ParseFileResponse(FileUpload.Utility.CacheFileUploadService.ParseFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org")]
    public partial class ParseFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public FileUpload.Utility.CacheFileUploadService.ArrayOfErrorMessageErrorMessage ParseFileResult;
        
        public ParseFileResponseBody() {
        }
        
        public ParseFileResponseBody(FileUpload.Utility.CacheFileUploadService.ArrayOfErrorMessageErrorMessage ParseFileResult) {
            this.ParseFileResult = ParseFileResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Test", Namespace="http://tempuri.org", Order=0)]
        public FileUpload.Utility.CacheFileUploadService.TestRequestBody Body;
        
        public TestRequest() {
        }
        
        public TestRequest(FileUpload.Utility.CacheFileUploadService.TestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class TestRequestBody {
        
        public TestRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestResponse", Namespace="http://tempuri.org", Order=0)]
        public FileUpload.Utility.CacheFileUploadService.TestResponseBody Body;
        
        public TestResponse() {
        }
        
        public TestResponse(FileUpload.Utility.CacheFileUploadService.TestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org")]
    public partial class TestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TestResult;
        
        public TestResponseBody() {
        }
        
        public TestResponseBody(string TestResult) {
            this.TestResult = TestResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FileUploadServiceSoapChannel : FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileUploadServiceSoapClient : System.ServiceModel.ClientBase<FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap>, FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap {
        
        public FileUploadServiceSoapClient() {
        }
        
        public FileUploadServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileUploadServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FileUpload.Utility.CacheFileUploadService.ParseFileResponse FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap.ParseFile(FileUpload.Utility.CacheFileUploadService.ParseFileRequest request) {
            return base.Channel.ParseFile(request);
        }
        
        public FileUpload.Utility.CacheFileUploadService.ArrayOfErrorMessageErrorMessage ParseFile(string FileName) {
            FileUpload.Utility.CacheFileUploadService.ParseFileRequest inValue = new FileUpload.Utility.CacheFileUploadService.ParseFileRequest();
            inValue.Body = new FileUpload.Utility.CacheFileUploadService.ParseFileRequestBody();
            inValue.Body.FileName = FileName;
            FileUpload.Utility.CacheFileUploadService.ParseFileResponse retVal = ((FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap)(this)).ParseFile(inValue);
            return retVal.Body.ParseFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FileUpload.Utility.CacheFileUploadService.ParseFileResponse> FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap.ParseFileAsync(FileUpload.Utility.CacheFileUploadService.ParseFileRequest request) {
            return base.Channel.ParseFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<FileUpload.Utility.CacheFileUploadService.ParseFileResponse> ParseFileAsync(string FileName) {
            FileUpload.Utility.CacheFileUploadService.ParseFileRequest inValue = new FileUpload.Utility.CacheFileUploadService.ParseFileRequest();
            inValue.Body = new FileUpload.Utility.CacheFileUploadService.ParseFileRequestBody();
            inValue.Body.FileName = FileName;
            return ((FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap)(this)).ParseFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FileUpload.Utility.CacheFileUploadService.TestResponse FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap.Test(FileUpload.Utility.CacheFileUploadService.TestRequest request) {
            return base.Channel.Test(request);
        }
        
        public string Test() {
            FileUpload.Utility.CacheFileUploadService.TestRequest inValue = new FileUpload.Utility.CacheFileUploadService.TestRequest();
            inValue.Body = new FileUpload.Utility.CacheFileUploadService.TestRequestBody();
            FileUpload.Utility.CacheFileUploadService.TestResponse retVal = ((FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap)(this)).Test(inValue);
            return retVal.Body.TestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FileUpload.Utility.CacheFileUploadService.TestResponse> FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap.TestAsync(FileUpload.Utility.CacheFileUploadService.TestRequest request) {
            return base.Channel.TestAsync(request);
        }
        
        public System.Threading.Tasks.Task<FileUpload.Utility.CacheFileUploadService.TestResponse> TestAsync() {
            FileUpload.Utility.CacheFileUploadService.TestRequest inValue = new FileUpload.Utility.CacheFileUploadService.TestRequest();
            inValue.Body = new FileUpload.Utility.CacheFileUploadService.TestRequestBody();
            return ((FileUpload.Utility.CacheFileUploadService.FileUploadServiceSoap)(this)).TestAsync(inValue);
        }
    }
}
