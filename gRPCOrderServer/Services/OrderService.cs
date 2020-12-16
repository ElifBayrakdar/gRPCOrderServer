using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using V1;

namespace gRPCOrderServer
{
    public class OrderService : Order.OrderBase
    {
        private readonly ILogger<OrderService> _logger;
        public OrderService(ILogger<OrderService> logger)
        {
            _logger = logger;
        }

        public override Task<OrderResponse> GetOrder(OrderRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OrderResponse { Id = 2 });
        }

        public override async Task GetOrdersServerStream(Empty request,
                                                         IServerStreamWriter<OrderResponse> responseStream,
                                                         ServerCallContext context)
        {
            while (!context.CancellationToken.IsCancellationRequested)
            {
                await responseStream.WriteAsync(new OrderResponse());
                await Task.Delay(TimeSpan.FromSeconds(1), context.CancellationToken);
            }
        }
    }
}
