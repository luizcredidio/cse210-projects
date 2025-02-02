using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("525 S Center St", "Rexburg", "Idaho", "USA");
        Address brasilAddress = new Address("Rua Max Colin, n1850", "Joinville", "Santa Catarina", "Brasil");

        Customer usCustomer = new Customer("John Doe", usaAddress);
        Customer brasilCustomer = new Customer("João da Silva", brasilAddress);

        Product laptop = new Product("Laptop", 1000, 999.99, 1);
        Product mouse = new Product("Mouse", 1000, 22.99, 2);
        Product keyboard = new Product("Keyboard", 1000, 89.99, 1);
        Product monitor = new Product("Monitor", 2000, 299.99, 2);

        Order usaOrder = new Order();
        usaOrder.SetCustomer(usCustomer);
        usaOrder.AddProduct(laptop);
        usaOrder.AddProduct(mouse);

        Order brasilOrder = new Order();
        brasilOrder.SetCustomer(brasilCustomer);
        brasilOrder.AddProduct(keyboard);
        brasilOrder.AddProduct(monitor);

        Console.WriteLine("USA Order ----");
        Console.WriteLine("Packaging Label: ");
        usaOrder.DisplayPackagingLabel();
        Console.WriteLine("Shipping Label: ");
        usaOrder.DisplayShippingLabel();
        Console.WriteLine($"Total Cost: ${usaOrder.GetTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("BRASIL Order ----");
        Console.WriteLine("Packaging Label: ");
        brasilOrder.DisplayPackagingLabel();
        Console.WriteLine("Shipping Label: ");
        brasilOrder.DisplayShippingLabel();
        Console.WriteLine($"Total Cost: ${brasilOrder.GetTotalCost()}");
    }
}
