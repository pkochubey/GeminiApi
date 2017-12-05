using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeminiApi.Models.Requests
{
    public class OrderStatusRequest : BasicRequest
    {
        [JsonProperty("order_id")]
        public int OrderId { get; internal set; }

        public OrderStatusRequest(string url, int orderId) : base(url)
        {
            OrderId = orderId;
        }
    }
}
