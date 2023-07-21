using PetStore;

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

        Console.WriteLine(String.Format("Name: {0}\nPrice: {1}\nQuantity: {2}\nDescription: {3}\nMaterial: {4}\nLength(in): {5}",
            leash.Name, leash.Price, leash.Quantity, leash.Description, leash.Material, leash.LengthInches));
    }

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}