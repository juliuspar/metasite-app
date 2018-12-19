using System.Collections.Generic;
using Newtonsoft.Json;

namespace MetasiteApp.Phones.Calls
{
    public class Top5PhoneNumbersWithLongestCallsResult
    {
        public Top5PhoneNumbersWithLongestCallsResult(IList<string> numbers)
            => Numbers = numbers;

        [JsonProperty("numbers")]
        public IList<string> Numbers { get; }
    }
}
