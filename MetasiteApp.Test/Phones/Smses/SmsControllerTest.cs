using System.Threading.Tasks;
using FluentAssertions;
using Flurl.Http;
using MetasiteApp.Phones.Smses;
using MetasiteApp.Test.Phones.Fixtures;
using Xunit;

namespace MetasiteApp.Test.Phones.Smses
{
    public class SmsControllerTest : IClassFixture<TestServerFixture>
    {
        private readonly FlurlClient _client;

        public SmsControllerTest(TestServerFixture fixture)
            => _client = fixture.ServerClient;

        [Fact]
        public async Task ReturnsTotalNumberOfSms()
        {
            var result = await _client.
                Request("api/sms/total?from=2018.01.01&to=2018.12.31").
                GetJsonAsync<TotalSmsResult>();

            result.Total.Should().Be(99);
        }

        [Fact]
        public async Task ReturnsTop5NumbersWithMostSms()
        {
            var result = await _client.
                Request("api/sms/top5/most?from=2018.01.01&to=2018.12.31").
                GetJsonAsync<Top5PhoneNumbersByMostSmsResult>();

            result.Numbers.Count.Should().Be(5);
        }
    }
}
