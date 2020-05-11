using System;
using System.Collections.Generic;
using CSharpMedium.Entities.Enums;

namespace CSharpMedium.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client IClient { get; set; }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        /*public void AddClient(IClien){
            IClient.Name;
        }*/

        public double Total(OrderItem item)
        {
            double sum = 0;
            foreach (OrderItem it in Items)
            {
                sum += it.SubTotal(it.Quantity, it.Price);
            }
            return sum;
        }
    }
}
