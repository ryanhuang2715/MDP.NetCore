﻿using Autofac;
using Autofac.Builder;
using System;

namespace CLK.Autofac
{
    public static partial class ContainerBuilderExtensions
    {
        // Methods  
        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> RegisterInterface<TService>(this ContainerBuilder container, Func<string> typeAction)
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (typeAction == null) throw new ArgumentException(nameof(typeAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.ResolveNamed<TService>(() => componentContext.Build(typeAction));
            });
        }

        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> RegisterInterface<T1, TService>(this ContainerBuilder container, Func<T1, string> typeAction)
            where T1 : class
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (typeAction == null) throw new ArgumentException(nameof(typeAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.ResolveNamed<TService>(() => componentContext.Build(typeAction));
            });
        }

        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> RegisterInterface<T1, T2, TService>(this ContainerBuilder container, Func<T1, T2, string> typeAction)
            where T1 : class
            where T2 : class
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (typeAction == null) throw new ArgumentException(nameof(typeAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.ResolveNamed<TService>(() => componentContext.Build(typeAction));
            });
        }

        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> RegisterInterface<T1, T2, T3, TService>(this ContainerBuilder container, Func<T1, T2, T3, string> typeAction)
            where T1 : class
            where T2 : class
            where T3 : class
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (typeAction == null) throw new ArgumentException(nameof(typeAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.ResolveNamed<TService>(() => componentContext.Build(typeAction));
            });
        }
    }

    public static partial class ContainerBuilderExtensions
    {
        // Methods 
        public static IRegistrationBuilder<TImplementer, ConcreteReflectionActivatorData, SingleRegistrationStyle> RegisterImplementer<TService, TImplementer>(this ContainerBuilder container)
            where TImplementer : TService
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));

            #endregion

            // Return
            return container.RegisterType<TImplementer>().Named<TService>(typeof(TImplementer).FullName);
        }

        public static IRegistrationBuilder<TImplementer, SimpleActivatorData, SingleRegistrationStyle> RegisterImplementer<TService, TImplementer>(this ContainerBuilder container, Func<TImplementer> buildAction)
            where TService : class
            where TImplementer : class, TService
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register(buildAction).Named<TService>(typeof(TImplementer).FullName);
        }

        public static IRegistrationBuilder<TImplementer, SimpleActivatorData, SingleRegistrationStyle> RegisterImplementer<T1, TService, TImplementer>(this ContainerBuilder container, Func<T1, TImplementer> buildAction)
            where T1 : class
            where TService : class
            where TImplementer : class, TService
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register(buildAction).Named<TService>(typeof(TImplementer).FullName);
        }

        public static IRegistrationBuilder<TImplementer, SimpleActivatorData, SingleRegistrationStyle> RegisterImplementer<T1, T2, TService, TImplementer>(this ContainerBuilder container, Func<T1, T2, TImplementer> buildAction)
            where T1 : class
            where T2 : class
            where TService : class
            where TImplementer : class, TService
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register(buildAction).Named<TService>(typeof(TImplementer).FullName);
        }

        public static IRegistrationBuilder<TImplementer, SimpleActivatorData, SingleRegistrationStyle> RegisterImplementer<T1, T2, T3, TService, TImplementer>(this ContainerBuilder container, Func<T1, T2, T3, TImplementer> buildAction)
            where T1 : class
            where T2 : class
            where T3 : class
            where TService : class
            where TImplementer : class, TService
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register(buildAction).Named<TService>(typeof(TImplementer).FullName);
        }
    }

    public static partial class ContainerBuilderExtensions
    {
        // Methods   
        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> Register<TService>(this ContainerBuilder container, Func<TService> buildAction) 
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.Build(buildAction);
            });
        }

        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> Register<T1, TService>(this ContainerBuilder container, Func<T1, TService> buildAction)
            where T1 : class
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.Build(buildAction);
            });
        }

        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> Register<T1, T2, TService>(this ContainerBuilder container, Func<T1, T2, TService> buildAction)
            where T1 : class
            where T2 : class
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.Build(buildAction);
            });
        }

        public static IRegistrationBuilder<TService, SimpleActivatorData, SingleRegistrationStyle> Register<T1, T2, T3, TService>(this ContainerBuilder container, Func<T1, T2, T3, TService> buildAction)
            where T1 : class
            where T2 : class
            where T3 : class
            where TService : class
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));
            if (buildAction == null) throw new ArgumentException(nameof(buildAction));

            #endregion

            // Register
            return container.Register<TService>(componentContext =>
            {
                // Resolve
                return componentContext.Build(buildAction);
            });
        }
    }
}