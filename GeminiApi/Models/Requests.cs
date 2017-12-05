using System;
using System.Collections.Generic;
using GeminiApi.Models.Requests;

namespace GeminiApi.Models
{
    public class HeartBeat : BasicRequest
    {
        public HeartBeat() : base("/v1/heartbeat", DateTimeOffset.Now.ToUnixTimeMilliseconds()) { }
    }

    public class NewOrder : OrderRequest
    {
        public NewOrder() : base("/v1/order/new", DateTimeOffset.Now.ToUnixTimeMilliseconds()) { }
    }

    public class CancelAllOrder : BasicRequest
    {
        public CancelAllOrder() : base("/v1/order/cancel/all", DateTimeOffset.Now.ToUnixTimeMilliseconds()) { }
    }

    public class CancelOrder : OrderStatusRequest
    {
        public CancelOrder(int orderId) : base("/v1/order/cancel", DateTimeOffset.Now.ToUnixTimeMilliseconds(), orderId) { }
    }

    public class GetAvailableBalances : BasicRequest
    {
        public GetAvailableBalances() : base("/v1/balances", DateTimeOffset.Now.ToUnixTimeMilliseconds()) { }
    }

    public class GetOrderStatus : OrderStatusRequest
    {
        public GetOrderStatus(int orderId) : base("/v1/order/status", DateTimeOffset.Now.ToUnixTimeMilliseconds(), orderId) { }
    }

    public class GetActiveOrders : BasicRequest
    {
        public GetActiveOrders() : base("/v1/orders", DateTimeOffset.Now.ToUnixTimeMilliseconds()) { }
    }
}
