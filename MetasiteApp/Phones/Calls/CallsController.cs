using System;
using System.Threading.Tasks;
using MetasiteApp.Phones.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace MetasiteApp.Phones.Calls
{
    [Route("api/calls")]
    public class CallsController : Controller
    {
        private readonly CallsRepository _calls;

        public CallsController(CallsRepository calls) 
            => _calls = calls;

        [HttpGet("total")]
        public async Task<IActionResult> Total([FromQuery]DateTime? from, [FromQuery]DateTime? to) 
            => Ok(new TotalCallsResult(
                await _calls.Total(from.DefaultToMin(), to.DefaultToMax())));

        [HttpGet("top5/longest")]
        public async Task<IActionResult> Top5PhoneNumbersWithLongestCalls([FromQuery]DateTime? from, [FromQuery]DateTime? to) 
            => Ok(new Top5PhoneNumbersWithLongestCallsResult(
                await _calls.Top5PhoneNumbersWithLongestCalls(from.DefaultToMin(), to.DefaultToMax())));
    }
}
