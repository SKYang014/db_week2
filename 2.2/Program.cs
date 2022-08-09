

Console.WriteLine("Welcome to Chirpus Market!");
bool ask = true;
List<string> cart = new List<string>();

Dictionary<string, decimal> item = new Dictionary<string, decimal>();
item["apple"] = 0.99m;
item["banana"] = 0.59m;
item["cauliflower"] = 1.59m;
item["dragonfruit"] = 2.19m;
item["elderberry"] = 1.79m;
item["figs"] = 2.09m;
item["grapefruit"] = 0.59m;
item["honeydew"] = 0.99m;

do
{
    Console.WriteLine("================================");
    Console.WriteLine("Today's Market Menu:\nItem\t\tPrice");
    Console.WriteLine("================================");
    foreach (var pair in item)
    {
        Console.WriteLine(pair.Key + "\t" + pair.Value);
    }
    Console.WriteLine("================================");
    Console.WriteLine("What item would you like to order?");
    string input = Console.ReadLine();
    if (input != null && item.ContainsKey(input))
    {
        Console.WriteLine($"Adding {input} to cart at {item[input]}");
        cart.Add(input);
    }
    else
    {
        Console.WriteLine($"{input} does not exsist");
    }
    
    ask = again();
    if (!ask)
    {
        
        Console.WriteLine();
        Console.WriteLine("Thanks for your order" +
            "\nHere's what you got:" +
            "\n================================" +
            "\nItem\t\tPrice" +
            "\n================================");
        decimal total = 0;
        //cart.Sort();
        foreach (var product in cart)
        {
            Console.WriteLine(product+"\t\t"+item[product]);
              total +=  item[product];
        }
        Console.WriteLine("================================");
        Console.WriteLine($"Your total is: ${total}\nHave a great day!");
        
    }
} while (ask);

static bool again()
{
    Console.WriteLine("Would you like to order anything else? enter yes or no");
    string answer = Console.ReadLine();
    if (answer=="yes")
    {
        return true;
    }
    else
    {
        return false;
    }
}