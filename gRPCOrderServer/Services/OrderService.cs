using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using gRPCOrderServer.Services;
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
            List<OrderItem> orderItems = OrderRepository.Orders();
            OrderResponse orderResponse = new OrderResponse();
            orderResponse.Orders.Add(orderItems.FirstOrDefault(o => o.Id == request.Id));            
            return Task.FromResult(orderResponse);
        }

        public override async Task GetOrdersServerStream(Empty request,
                                                         IServerStreamWriter<OrderResponse> responseStream,
                                                         ServerCallContext context)
        {
            OrderResponse orderResponse;
            List<OrderItem> orderItems = OrderRepository.Orders();
            foreach (var orderItem in orderItems)
            {
                orderResponse = new OrderResponse();
                orderResponse.Orders.Add(orderItem);
                await responseStream.WriteAsync(orderResponse);
                await Task.Delay(TimeSpan.FromSeconds(1), context.CancellationToken);
            }
        }

        public override async Task<OrderResponse> GetOrdersClientStream(IAsyncStreamReader<OrderRequest> requestStream,
                                                                        ServerCallContext context)
        {
            OrderResponse orderResponse = new OrderResponse();
            List<OrderItem> orderItems = OrderRepository.Orders();
            await foreach (var message in requestStream.ReadAllAsync())
            {
                orderResponse.Orders.Add(orderItems.FirstOrDefault(o => o.Id == message.Id));
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            return orderResponse;
        }
    }
}
