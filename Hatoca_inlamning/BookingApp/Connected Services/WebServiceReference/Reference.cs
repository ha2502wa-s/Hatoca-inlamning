﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingApp.WebServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://hatoca.lu.se", ConfigurationName="WebServiceReference.CSharpWebServiceSoap")]
    public interface CSharpWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name filename from namespace http://hatoca.lu.se is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://hatoca.lu.se/GetFileContent", ReplyAction="*")]
        BookingApp.WebServiceReference.GetFileContentResponse GetFileContent(BookingApp.WebServiceReference.GetFileContentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hatoca.lu.se/GetFileContent", ReplyAction="*")]
        System.Threading.Tasks.Task<BookingApp.WebServiceReference.GetFileContentResponse> GetFileContentAsync(BookingApp.WebServiceReference.GetFileContentRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFileContentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFileContent", Namespace="http://hatoca.lu.se", Order=0)]
        public BookingApp.WebServiceReference.GetFileContentRequestBody Body;
        
        public GetFileContentRequest() {
        }
        
        public GetFileContentRequest(BookingApp.WebServiceReference.GetFileContentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://hatoca.lu.se")]
    public partial class GetFileContentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string filename;
        
        public GetFileContentRequestBody() {
        }
        
        public GetFileContentRequestBody(string filename) {
            this.filename = filename;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFileContentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFileContentResponse", Namespace="http://hatoca.lu.se", Order=0)]
        public BookingApp.WebServiceReference.GetFileContentResponseBody Body;
        
        public GetFileContentResponse() {
        }
        
        public GetFileContentResponse(BookingApp.WebServiceReference.GetFileContentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://hatoca.lu.se")]
    public partial class GetFileContentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetFileContentResult;
        
        public GetFileContentResponseBody() {
        }
        
        public GetFileContentResponseBody(string GetFileContentResult) {
            this.GetFileContentResult = GetFileContentResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CSharpWebServiceSoapChannel : BookingApp.WebServiceReference.CSharpWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CSharpWebServiceSoapClient : System.ServiceModel.ClientBase<BookingApp.WebServiceReference.CSharpWebServiceSoap>, BookingApp.WebServiceReference.CSharpWebServiceSoap {
        
        public CSharpWebServiceSoapClient() {
        }
        
        public CSharpWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CSharpWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CSharpWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CSharpWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BookingApp.WebServiceReference.GetFileContentResponse BookingApp.WebServiceReference.CSharpWebServiceSoap.GetFileContent(BookingApp.WebServiceReference.GetFileContentRequest request) {
            return base.Channel.GetFileContent(request);
        }
        
        public string GetFileContent(string filename) {
            BookingApp.WebServiceReference.GetFileContentRequest inValue = new BookingApp.WebServiceReference.GetFileContentRequest();
            inValue.Body = new BookingApp.WebServiceReference.GetFileContentRequestBody();
            inValue.Body.filename = filename;
            BookingApp.WebServiceReference.GetFileContentResponse retVal = ((BookingApp.WebServiceReference.CSharpWebServiceSoap)(this)).GetFileContent(inValue);
            return retVal.Body.GetFileContentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BookingApp.WebServiceReference.GetFileContentResponse> BookingApp.WebServiceReference.CSharpWebServiceSoap.GetFileContentAsync(BookingApp.WebServiceReference.GetFileContentRequest request) {
            return base.Channel.GetFileContentAsync(request);
        }
        
        public System.Threading.Tasks.Task<BookingApp.WebServiceReference.GetFileContentResponse> GetFileContentAsync(string filename) {
            BookingApp.WebServiceReference.GetFileContentRequest inValue = new BookingApp.WebServiceReference.GetFileContentRequest();
            inValue.Body = new BookingApp.WebServiceReference.GetFileContentRequestBody();
            inValue.Body.filename = filename;
            return ((BookingApp.WebServiceReference.CSharpWebServiceSoap)(this)).GetFileContentAsync(inValue);
        }
    }
}
