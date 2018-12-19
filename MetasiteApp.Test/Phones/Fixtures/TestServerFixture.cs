using System;
using Flurl.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;

namespace MetasiteApp.Test.Phones.Fixtures
{
    public class TestServerFixture : IDisposable
    {
        private readonly TestServer _server;

        public TestServerFixture()
        {
            string projectDir = System.IO.Path.GetFullPath(@"..\..\..\..\MetasiteApp");

            _server = new TestServer(new WebHostBuilder().
                UseEnvironment("Development").
                UseContentRoot(projectDir).
                UseConfiguration(new ConfigurationBuilder().
                    SetBasePath(projectDir).
                    AddJsonFile("appsettings.json").
                    Build()
                ).
                UseStartup<Startup>());

            ServerClient = new FlurlClient(_server.CreateClient());
        }

        public FlurlClient ServerClient { get; }

        public void Dispose() => _server.Dispose();
    }
}