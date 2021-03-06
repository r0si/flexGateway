﻿using flexGateway.Common.Plugins;
using Microsoft.Extensions.DependencyInjection;
using flexGateway.Common.AdapterNode;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using flexGateway.Common.Adapter;

namespace flexGateway.Server
{
    public static class HostExtension
    {
        public static IHost LoadPlugins(this IHost host)
        {
            var pluginManager = new PluginManager(
                host.Services.GetService<IAdapterFactory>(),
                host.Services.GetService<INodeFactory>());
            pluginManager.LoadPlugins(host.Services.GetService<ILogger<PluginManager>>());

            return host;
        }
    }
}
