﻿#region File Description

//-----------------------------------------------------------------------------
// ServiceContainer.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;

#pragma warning disable CS1591

namespace Penumbra
{
    public class ServiceContainerPenumbra : IServiceProvider
    {
        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        /// <summary>
        ///     Looks up the specified service.
        /// </summary>
        public object GetService(Type serviceType)
        {
            object service;
            _services.TryGetValue(serviceType, out service);
            return service;
        }

        /// <summary>
        ///     Adds a new service to the collection.
        /// </summary>
        public void AddService<T>(T service)
        {
            _services.Add(typeof(T), service);
        }
    }
}