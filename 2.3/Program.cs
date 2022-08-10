Console.WriteLine("Hello welcome to the string reverser 3000");
bool again = true;
do
{
    Console.Write("Enter a word to reverse: ");
    string input = Console.ReadLine();
    //put each letter into a list
    Console.WriteLine(reaver(input));

    //reverser.Clear();
    Console.WriteLine();
    again = keepGoing();
} while (again);

static string reaver (string input)
{
    Stack<string> reverser = new Stack<string>();
    List<char> characters = new List<char>();
    List<string> rCharacters = new List<string>();
    string revLetters = "";

    //break down input into a list of characters
    for (int i = 0; i < input.Length; i++)
    {
        //Console.WriteLine(input[i]);
        characters.Add(input[i]);
    }
    //for each letter, put it in a stack, convert to string as it seems stacks cannot hold characters
    for (int i = 0; i < characters.Count; i++)
    {
        //Console.WriteLine(characters[i]);
        reverser.Push(characters[i].ToString());
    }
    //pop the letters in reverse to another list
    while (reverser.Count > 0)
    {
        rCharacters.Add(reverser.Pop());
    }
    //loop through list to add each character to string
    for (int i = 0; i < rCharacters.Count; i++)
    {
        Console.WriteLine(rCharacters[i]);
        revLetters += rCharacters[i];
    }


    return revLetters;
}


static bool keepGoing()
{
    while (true)
    {
    Console.WriteLine("Do you want to play again? Please enter y/n");
    string answer = Console.ReadLine();
    if (answer == "y" || answer == "yes")
    {
        return true;
    }
    else if (answer == "n" || answer == "no")
    {
        Console.WriteLine("See ya nerd!");
        return false;
    }
    else
        {
            Console.WriteLine($"Why'd you say {answer}?  Please only put in y or n");
        }
    }
}
