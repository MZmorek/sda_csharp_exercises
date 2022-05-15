namespace sda_csharp_exercises
{
    public class OrderItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            this.ProductName = productName;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }

        public virtual decimal GetValue()
        {
            return Quantity * UnitPrice;
        }
        public override string ToString()
        {
            return $"{ProductName}, cena: {UnitPrice}, {Quantity} szt, wartość: {GetValue()}";
        }
    }
   
}
