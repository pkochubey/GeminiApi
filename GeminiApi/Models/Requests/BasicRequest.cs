using Newtonsoft.Json;

namespace GeminiApi.Models.Requests
{
    public class BasicRequest
    {
        [JsonProperty("request")]
        public string Request { get; internal set; }

        [JsonProperty("nonce")]
        public long Nonce { get; internal set; }

        public BasicRequest(string request, long nonce)
        {
            Request = request;
            Nonce = nonce;
        }
    }
}
