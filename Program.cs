using PetStore;

ProductLogic logic = new ProductLogic();

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

while(userInput.ToLower() != "exit")
{
    if(userInput == "1")
    {
        DogLeash leash = new DogLeash();

        Console.Write("Please enter the name: ");
        leash.Name = Console.ReadLine();

        Console.Write("Please enter the price: ");
        leash.Price = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter the quantity: ");
        leash.Quantity = int.Parse(Console.ReadLine());

        Console.Write("Please enter the description: ");
        leash.Description = Console.ReadLine();

        Console.Write("Please enter the material type: ");
        leash.Material = Console.ReadLine();

        Console.Write("Please enter the length in inches: ");
        leash.LengthInches = int.Parse(Console.ReadLine());

        logic.AddProduct(leash);
        Console.Write("Your new product has been added!");
    } else if(userInput == "2")
    {
        Console.WriteLine("Specify a Dog Leash you would like to view.");
        userInput = Console.ReadLine();

        DogLeash leash = logic.GetDogLeashByName(userInput);

        if (leash is null)
        {
            Console.WriteLine("Leash not found.");
        } else
        {
            Console.WriteLine(String.Format("Name: {0}\nPrice: {1}\nQuantity: {2}\nDescription: {3}\nMaterial: {4}\nLength(in): {5}",
                leash.Name, leash.Price, leash.Quantity, leash.Description, leash.Material, leash.LengthInches));
        }
    } else if(userInput == "3")
    {
        var stock = logic.GetOnlyInStockProducts();
        foreach (string item in stock)
        {
            Console.WriteLine(item);
        }
    }

    Console.WriteLine("\nPress 1 to add a product");
    Console.WriteLine("Press 2 to view a product");
    Console.WriteLine("Press 3 to view products in stock.");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}