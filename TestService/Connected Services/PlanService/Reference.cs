﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestService.PlanService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PlanService.ISystemPlanService")]
    public interface ISystemPlanService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemPlanService/AutoXfPlan", ReplyAction="http://tempuri.org/ISystemPlanService/AutoXfPlanResponse")]
        string AutoXfPlan(System.DateTime beginTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISystemPlanService/AutoXfPlan", ReplyAction="http://tempuri.org/ISystemPlanService/AutoXfPlanResponse")]
        System.Threading.Tasks.Task<string> AutoXfPlanAsync(System.DateTime beginTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISystemPlanServiceChannel : TestService.PlanService.ISystemPlanService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SystemPlanServiceClient : System.ServiceModel.ClientBase<TestService.PlanService.ISystemPlanService>, TestService.PlanService.ISystemPlanService {
        
        public SystemPlanServiceClient() {
        }
        
        public SystemPlanServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SystemPlanServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemPlanServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SystemPlanServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AutoXfPlan(System.DateTime beginTime) {
            return base.Channel.AutoXfPlan(beginTime);
        }
        
        public System.Threading.Tasks.Task<string> AutoXfPlanAsync(System.DateTime beginTime) {
            return base.Channel.AutoXfPlanAsync(beginTime);
        }
    }
}
