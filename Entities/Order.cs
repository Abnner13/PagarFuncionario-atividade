using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CSharpMedium.Entities.Enums;

namespace CSharpMedium.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client IClient { get; set; }

        public Order(DateTime moment, OrderStatus status, Client iclient)
        {
            Moment = moment;
            Status = status;
            IClient = iclient;
            
        }
        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }


        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem it in Items)
            {
                sum += it.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine( "Order status: " + Status);
            sb.AppendLine("Client: " + IClient);
            sb.AppendLine("Order Items :");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
