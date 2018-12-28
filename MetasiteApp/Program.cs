using System;
using MetasiteApp.Phones.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace MetasiteApp
{
    public class Program
    {
        public static void Main(string[] args) => 
            BuildWebHost(args).Run();

        private static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args).
            UseStartup<Startup>().
            Build();
    }
}
