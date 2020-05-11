using System.Globalization;
using System.Text;

namespace CSharpMedium.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product IProduct { get; set; }

        public OrderItem(Product iproduct, int quantity, double price)
        {
            Quantity = quantity;
            IProduct = iproduct;
            Price = price;
        }

        public double SubTotal(){
            return Quantity * Price;
        }

        public override string ToString(){
            StringBuilder sb = new StringBuilder();

            sb.Append(IProduct.Name);
            sb.Append(", $" + IProduct.Price+ ", ");
            sb.Append("Quantity: " + Quantity+ ", ");
            sb.AppendLine("Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        } 
    }
}
