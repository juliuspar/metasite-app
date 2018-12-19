using System.Threading.Tasks;
using FluentAssertions;
using MetasiteApp.Phones.Smses;
using MetasiteApp.Test.Phones.Data;
using Xunit;
using static System.DateTime;
using static System.TimeSpan;

namespace MetasiteApp.Test.Phones.Smses
{
    public class SmsRepositoryTest
    {
        [Fact]
        public async Task ReturnsTotal()
        {
            using (var context = new TestTspDatabaseContext().InMemory())
            {
                await context.Phones.AddAsync(
                    new PhoneBuilder().Id(1).Number("3706000002").AddSmsForNow(1).Build());

                await context.SaveChangesAsync();

                int result = await new SmsRepository(context).Total(
                    Now - FromHours(1), 
                    Now + FromHours(1));

                result.Should().Be(1);
            }
        }

        [Fact]
        public async Task ReturnsTop5()
        {
            using (var context = new TestTspDatabaseContext().InMemory())
            {
                await context.AddRangeAsync(
                    new PhoneBuilder().Id(1).Number("3706000002").AddSmsForNow(2).Build(),
                    new PhoneBuilder().Id(2).Number("3706000004").AddSmsForNow(1).Build(),
                    new PhoneBuilder().Id(3).Number("3706000005").AddSmsForNow(1).Build(),
                    new PhoneBuilder().Id(4).Number("3706000003").AddSmsForNow(3).Build(),
                    new PhoneBuilder().Id(5).Number("3706000001").AddSmsForNow(1).Build());

                await context.SaveChangesAsync();

                var results = await new SmsRepository(context).Top5PhoneNumbersWithMostSms(
                    Now - FromHours(1),
                    Now + FromHours(1));

                results.Count.Should().Be(5);
                results[0].Should().Be("3706000003");
                results[1].Should().Be("3706000002");
            }
        }
    }
}
