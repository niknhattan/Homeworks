﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FileUpload.Data;
using Ninject;
using Ninject.Syntax;

namespace FileUpload.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {

        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IUowData>().To<UowData>();
        }
    }
}