namespace OOPs {
    public class Product
    {
        public string productId;
        public string productName;
        public double productCost;
        public int quantity;

        public Product(string id, string name, double cost, int quantity)
        {
            productId = id;
            productName = name;
            productCost = cost;
            this.quantity = quantity;
        }

        public void PrintProductData()
        {
            System.Console.WriteLine($"ID: {productId}\nName: {productName}\nCost: {productCost}\nQuantity: {quantity}");
        }
    }
}