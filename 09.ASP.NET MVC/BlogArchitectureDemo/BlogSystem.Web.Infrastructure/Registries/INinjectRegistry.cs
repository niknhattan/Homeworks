﻿namespace BlogSystem.Web.Infrastructure.Registries
{
    using Ninject;

    public interface INinjectRegistry
    {
        void Register(IKernel kernel);
    }
}
