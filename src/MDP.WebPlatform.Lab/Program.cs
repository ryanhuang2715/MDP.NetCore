using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDP.WebPlatform.Lab
{
    public class Program
    {
        // Methods
        public static void Main(string[] args)
        {
            // Host
            MDP.WebPlatform.Host.CreateHostBuilder(args).Build().Run();
        }
    }
}