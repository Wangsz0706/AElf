﻿using AElf.SmartContract.Metadata;
using Autofac;

namespace AElf.SmartContract
{
    public class SmartContractAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly1 = typeof(IStateDictator).Assembly;
            builder.RegisterAssemblyTypes(assembly1).AsImplementedInterfaces();
            
            var assembly2 = typeof(StateDictator).Assembly;
            builder.RegisterAssemblyTypes(assembly2).AsImplementedInterfaces();
            
            builder.RegisterType(typeof(FunctionMetadataService)).As<IFunctionMetadataService>().SingleInstance();
        }
    }
}