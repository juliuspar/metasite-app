using Newtonsoft.Json;

namespace MetasiteApp.Phones.Calls
{
    public class TotalCallsResult
    {
        public TotalCallsResult(int total)
            => Total = total;

        [JsonProperty("total")]
        public int Total { get; }
    }
}
