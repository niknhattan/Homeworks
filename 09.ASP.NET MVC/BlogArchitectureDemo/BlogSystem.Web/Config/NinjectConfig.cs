[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(BlogSystem.Web.App_Start.NinjectConfig), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(BlogSystem.Web.App_Start.NinjectConfig), "Stop")]

namespace BlogSystem.Web.App_Start
{
    using System;
    using System.Linq;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;
    using BlogSystem.Web.Infrastructure.Registries;
    using BlogSystem.Web.Infrastructure.Constants;
    using System.Reflection;
    using BlogSystem.Web.Infrastructure;
    using BlogSystem.Data;

    public static class NinjectConfig
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                ObjectFactory.InitializeKernel(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            var registries =
                Assembly.Load(Assemblies.Infrastructure)
                    .GetExportedTypes()
                    .Where(t => t.IsClass && typeof(INinjectRegistry).IsAssignableFrom(t));

            foreach (var registry in registries)
            {
                var registryInstance = (INinjectRegistry)Activator.CreateInstance(registry);
                registryInstance.Register(kernel);
            }
        }        
    }
}
