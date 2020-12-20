using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V1;

namespace gRPCOrderServer.Services
{
    public class OrderRepository
    {
        public OrderRepository()
        {
            orderDetails1 = new List<OrderDetail>();
            orderDetails2 = new List<OrderDetail>();
            orderDetails3 = new List<OrderDetail>();
            orderDetails4 = new List<OrderDetail>();

            order1 = new OrderItem { Id = 1 };
            order2 = new OrderItem { Id = 2 };
            order3 = new OrderItem { Id = 3 };
            order4 = new OrderItem { Id = 4 };

            orderDetails1.Add(detail1);
            orderDetails1.Add(detail2);

            orderDetails2.Add(detail3);
            orderDetails2.Add(detail4);

            orderDetails3.Add(detail5);
            orderDetails3.Add(detail6);
            orderDetails3.Add(detail7);
            orderDetails3.Add(detail8);
            orderDetails3.Add(detail9);
            orderDetails3.Add(detail10);

            orderDetails4.Add(detail11);
            orderDetails4.Add(detail12);
            orderDetails4.Add(detail13);
            orderDetails4.Add(detail14);
            orderDetails4.Add(detail15);

            order1.Details.AddRange(orderDetails1);
            order2.Details.AddRange(orderDetails2);
            order3.Details.AddRange(orderDetails3);
            order4.Details.AddRange(orderDetails4);
        }

        public static List<OrderItem> Orders()
        {
            OrderRepository repository = new OrderRepository();
            List<OrderItem> orders = new List<OrderItem>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);
            return orders;
        }



        public static InventoryItem item1 = new InventoryItem { Id = 1, Name = "TV" };
        public static InventoryItem item2 = new InventoryItem { Id = 2, Name = "Mobile Phone" };
        public static InventoryItem item3 = new InventoryItem { Id = 3, Name = "Computer" };
        public static InventoryItem item4 = new InventoryItem { Id = 4, Name = "Washing Machine" };
        public static InventoryItem item5 = new InventoryItem { Id = 5, Name = "Box" };
        public static InventoryItem item6 = new InventoryItem { Id = 6, Name = "Book" };
        public static InventoryItem item7 = new InventoryItem { Id = 7, Name = "Shoes" };
        public static InventoryItem item8 = new InventoryItem { Id = 8, Name = "Skirt" };
        public static InventoryItem item9 = new InventoryItem { Id = 9, Name = "Tea" };
        public static InventoryItem item10 = new InventoryItem { Id = 10, Name = "Domestos" };
        public static InventoryItem item11 = new InventoryItem { Id = 11, Name = "Dishing Machine" };
        public static InventoryItem item12 = new InventoryItem { Id = 12, Name = "Pencil" };
        public static InventoryItem item13 = new InventoryItem { Id = 13, Name = "Battery" };
        public static InventoryItem item14 = new InventoryItem { Id = 14, Name = "Candle" };

        public static OrderDetail detail1 = new OrderDetail { OrderId = 1, Item = item1, Quantity = 1 };
        public static OrderDetail detail2 = new OrderDetail { OrderId = 1, Item = item2, Quantity = 3 };
        public static OrderDetail detail3 = new OrderDetail { OrderId = 2, Item = item3, Quantity = 1 };
        public static OrderDetail detail4 = new OrderDetail { OrderId = 2, Item = item4, Quantity = 2 };
        public static OrderDetail detail5 = new OrderDetail { OrderId = 3, Item = item4, Quantity = 2 };
        public static OrderDetail detail6 = new OrderDetail { OrderId = 3, Item = item5, Quantity = 1 };
        public static OrderDetail detail7 = new OrderDetail { OrderId = 3, Item = item6, Quantity = 1 };
        public static OrderDetail detail8 = new OrderDetail { OrderId = 3, Item = item7, Quantity = 1 };
        public static OrderDetail detail9 = new OrderDetail { OrderId = 3, Item = item8, Quantity = 1 };
        public static OrderDetail detail10 = new OrderDetail { OrderId = 3, Item = item9, Quantity = 1 };
        public static OrderDetail detail11 = new OrderDetail { OrderId = 4, Item = item10, Quantity = 1 };
        public static OrderDetail detail12 = new OrderDetail { OrderId = 4, Item = item11, Quantity = 1 };
        public static OrderDetail detail13 = new OrderDetail { OrderId = 4, Item = item12, Quantity = 10 };
        public static OrderDetail detail14 = new OrderDetail { OrderId = 4, Item = item13, Quantity = 1 };
        public static OrderDetail detail15 = new OrderDetail { OrderId = 5, Item = item14, Quantity = 5 };

        public static List<OrderDetail> orderDetails1 = new List<OrderDetail>();
        public static List<OrderDetail> orderDetails2 = new List<OrderDetail>();
        public static List<OrderDetail> orderDetails3 = new List<OrderDetail>();
        public static List<OrderDetail> orderDetails4 = new List<OrderDetail>();

        public static OrderItem order1 = new OrderItem { Id = 1 };
        public static OrderItem order2 = new OrderItem { Id = 2 };
        public static OrderItem order3 = new OrderItem { Id = 3 };
        public static OrderItem order4 = new OrderItem { Id = 4 };

    }
}
