﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceHandle.EepPlanService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://main.ddcx.kt.com/", ConfigurationName="EepPlanService.DdcxMainDelegate")]
    public interface DdcxMainDelegate {
        
        // CODEGEN: 命名空间  的元素名称 arg0 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        ServiceHandle.EepPlanService.ddcxResponse ddcx(ServiceHandle.EepPlanService.ddcxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceHandle.EepPlanService.ddcxResponse> ddcxAsync(ServiceHandle.EepPlanService.ddcxRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ddcxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ddcx", Namespace="http://main.ddcx.kt.com/", Order=0)]
        public ServiceHandle.EepPlanService.ddcxRequestBody Body;
        
        public ddcxRequest() {
        }
        
        public ddcxRequest(ServiceHandle.EepPlanService.ddcxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class ddcxRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        public ddcxRequestBody() {
        }
        
        public ddcxRequestBody(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ddcxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ddcxResponse", Namespace="http://main.ddcx.kt.com/", Order=0)]
        public ServiceHandle.EepPlanService.ddcxResponseBody Body;
        
        public ddcxResponse() {
        }
        
        public ddcxResponse(ServiceHandle.EepPlanService.ddcxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class ddcxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public ddcxResponseBody() {
        }
        
        public ddcxResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DdcxMainDelegateChannel : ServiceHandle.EepPlanService.DdcxMainDelegate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DdcxMainDelegateClient : System.ServiceModel.ClientBase<ServiceHandle.EepPlanService.DdcxMainDelegate>, ServiceHandle.EepPlanService.DdcxMainDelegate {
        
        public DdcxMainDelegateClient() {
        }
        
        public DdcxMainDelegateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DdcxMainDelegateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DdcxMainDelegateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DdcxMainDelegateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceHandle.EepPlanService.ddcxResponse ServiceHandle.EepPlanService.DdcxMainDelegate.ddcx(ServiceHandle.EepPlanService.ddcxRequest request) {
            return base.Channel.ddcx(request);
        }
        
        public string ddcx(string arg0) {
            ServiceHandle.EepPlanService.ddcxRequest inValue = new ServiceHandle.EepPlanService.ddcxRequest();
            inValue.Body = new ServiceHandle.EepPlanService.ddcxRequestBody();
            inValue.Body.arg0 = arg0;
            ServiceHandle.EepPlanService.ddcxResponse retVal = ((ServiceHandle.EepPlanService.DdcxMainDelegate)(this)).ddcx(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceHandle.EepPlanService.ddcxResponse> ServiceHandle.EepPlanService.DdcxMainDelegate.ddcxAsync(ServiceHandle.EepPlanService.ddcxRequest request) {
            return base.Channel.ddcxAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceHandle.EepPlanService.ddcxResponse> ddcxAsync(string arg0) {
            ServiceHandle.EepPlanService.ddcxRequest inValue = new ServiceHandle.EepPlanService.ddcxRequest();
            inValue.Body = new ServiceHandle.EepPlanService.ddcxRequestBody();
            inValue.Body.arg0 = arg0;
            return ((ServiceHandle.EepPlanService.DdcxMainDelegate)(this)).ddcxAsync(inValue);
        }
    }
}
