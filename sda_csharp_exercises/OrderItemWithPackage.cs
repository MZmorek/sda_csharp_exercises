namespace sda_csharp_exercises
{
    public class OrderItemWithPackage : OrderItem
    {
        public string PackageName { get; set; }
        public decimal PackagePrice { get; set; }

        public OrderItemWithPackage(string productName, int quantity, decimal unitPrice, string packageName, decimal packagePrice)
            : base(productName, quantity, unitPrice)
        {
            this.PackageName = packageName;
            this.PackagePrice = packagePrice;
        }

        public override decimal GetValue()
        {
            return Quantity * UnitPrice + Quantity * PackagePrice;
        }

        public override string ToString()
        {
            return $"{ProductName}, cena: {UnitPrice}, opakowanie: {PackageName}, " +
                $"cena opakowania: {PackagePrice}, ilość: {Quantity} szt, wartość: {GetValue()}";
        }
    }
}
