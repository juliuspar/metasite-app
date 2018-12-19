using System.Threading.Tasks;
using FluentAssertions;
using MetasiteApp.Phones.Calls;
using MetasiteApp.Test.Phones.Data;
using Xunit;
using static System.DateTime;
using static System.TimeSpan;

namespace MetasiteApp.Test.Phones.Calls
{
    public class CallsRepositoryTest
    {
        [Fact]
        public async Task ReturnsTotal()
        {
            using (var context = new TestTspDatabaseContext().InMemory())
            {
                await context.Phones.AddAsync(
                    new PhoneBuilder().Id(1).Number("3706000002").AddCallForNow(1).Build());

                await context.SaveChangesAsync();

                var result = await new CallsRepository(context).
                    Total(Now - FromHours(1), Now + FromHours(1));

                result.Should().Be(1);
            }
        }

        [Fact]
        public async Task ReturnsTop5()
        {
            using (var context = new TestTspDatabaseContext().InMemory())
            {
                await context.AddRangeAsync(
                    new PhoneBuilder().Id(2).Number("3706000004").AddCallForNow(10).Build(),
                    new PhoneBuilder().Id(1).Number("3706000002").AddCallForNow(10).AddCallForNow(20).Build(),
                    new PhoneBuilder().Id(3).Number("3706000005").AddCallForNow(10).Build(),
                    new PhoneBuilder().Id(4).Number("3706000003").AddCallForNow(40).Build(),
                    new PhoneBuilder().Id(5).Number("3706000001").AddCallForNow(1).Build());

                await context.SaveChangesAsync();

                var results = await new CallsRepository(context).Top5PhoneNumbersWithLongestCalls(
                    Now - FromHours(1),
                    Now + FromHours(1));

                results.Count.Should().Be(5);
                results[0].Should().Be("3706000003");
                results[1].Should().Be("3706000002");
            }
        }
    }
}
