namespace CSharpMedium.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product IProduct { get; set; }

        public OrderItem(Product iproduct, int quantity)
        {
            Quantity = quantity;
            IProduct = iproduct;
        }

        public double SubTotal(int quantity, double price){
            return IProduct.Price * quantity;
        }
    }
}
