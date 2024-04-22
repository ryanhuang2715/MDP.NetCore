﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Reflection
{
    public static class Activator
    {
        // Methods
        public static object CreateInstance(System.Type instanceType)
        {
            #region Contracts

            if (instanceType == null) throw new ArgumentException($"{nameof(instanceType)}=null");

            #endregion

            // Return
            return MDP.Reflection.Activator.CreateInstance(instanceType, new DefaultParameterProvider());
        }

        public static object CreateInstance(System.Type instanceType, ParameterProvider parameterProvider)
        {
            #region Contracts

            if (instanceType == null) throw new ArgumentException($"{nameof(instanceType)}=null");
            if (parameterProvider == null) throw new ArgumentException($"{nameof(parameterProvider)}=null");

            #endregion

            // ConstructorInfo
            var constructorInfo = instanceType.GetConstructors().FirstOrDefault();
            if (constructorInfo == null) throw new InvalidOperationException($"{nameof(constructorInfo)}=null");

            // Parameters
            var parameters = new List<object>();
            foreach (var parameterInfo in constructorInfo.GetParameters())
            {
                parameters.Add(parameterProvider.GetValue(parameterInfo.ParameterType, parameterInfo.Name, parameterInfo.HasDefaultValue, parameterInfo.DefaultValue));
            }

            // Invoke
            var instance = constructorInfo.Invoke(parameters.ToArray());
            if (instance == null) throw new InvalidOperationException($"{nameof(instance)}=null");

            // Return
            return instance;
        }


        public static object ExecuteMethod(object instance, string methodName)
        {
            #region Contracts

            if (instance == null) throw new ArgumentException($"{nameof(instance)}=null");
            if (string.IsNullOrEmpty(methodName) == true) throw new ArgumentException($"{nameof(methodName)}=null");

            #endregion

            // Return
            return MDP.Reflection.Activator.ExecuteMethod(instance, methodName, new DefaultParameterProvider());
        }

        public static object ExecuteMethod(object instance, string methodName, ParameterProvider parameterProvider)
        {
            #region Contracts

            if (instance == null) throw new ArgumentException($"{nameof(instance)}=null");
            if (string.IsNullOrEmpty(methodName) == true) throw new ArgumentException($"{nameof(methodName)}=null");
            if (parameterProvider == null) throw new ArgumentException($"{nameof(parameterProvider)}=null");

            #endregion

            // MethodInfo
            var methodInfo = instance.GetType().GetMethod(methodName);
            if (methodInfo == null) throw new InvalidOperationException($"{nameof(methodInfo)}=null");

            // Parameters
            var parameters = new List<object>();
            foreach (var parameterInfo in methodInfo.GetParameters())
            {
                parameters.Add(parameterProvider.GetValue(parameterInfo.ParameterType, parameterInfo.Name, parameterInfo.HasDefaultValue, parameterInfo.DefaultValue));
            }

            // Invoke
            var result = methodInfo.Invoke(instance, parameters.ToArray());

            // Return
            return result;
        }
    }
}
