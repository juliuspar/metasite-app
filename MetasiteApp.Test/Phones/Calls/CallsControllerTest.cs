using System.Threading.Tasks;
using FluentAssertions;
using Flurl.Http;
using MetasiteApp.Phones.Calls;
using MetasiteApp.Test.Phones.Fixtures;
using Xunit;

namespace MetasiteApp.Test.Phones.Calls
{
    public class CallsControllerTest : IClassFixture<TestServerFixture>
    {
        private readonly FlurlClient _client;

        public CallsControllerTest(TestServerFixture fixture) 
            => _client = fixture.ServerClient;

        [Fact]
        public async Task ReturnsTotalNumberOfCalls()
        {
            var result = await _client.
                Request("api/calls/total?from=2018.01.01&to=2018.12.31").
                GetJsonAsync<TotalCallsResult>();

            result.Total.Should().Be(99);
        }

        [Fact]
        public async Task ReturnsTotalNumberOfCallsWithoutToDate()
        {
            var result = await _client.
                Request("api/calls/total?from=2018.01.01").
                GetJsonAsync<TotalCallsResult>();

            result.Total.Should().Be(99);
        }

        [Fact]
        public async Task ReturnsTotalNumberOfCallsWithoutDates()
        {
            var result = await _client.
                Request("api/calls/total").
                GetJsonAsync<TotalCallsResult>();

            result.Total.Should().Be(99);
        }

        [Fact]
        public async Task ReturnsTop5PhonesWithLongestCalls()
        {
            var result = await _client.
                Request("api/calls/top5/longest?from=2018.01.01&to=2018.12.31").
                GetJsonAsync<Top5PhoneNumbersWithLongestCallsResult>();

            result.Numbers.Count.Should().Be(5);
        }
    }
}
