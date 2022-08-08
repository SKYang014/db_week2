bool keepGoing = true;


//while (keepGoing)
//{
    while (keepGoing)
    {
       //bool validInt = true;
        Console.WriteLine("Learn your squares and cubes!");
        Console.Write("Enter an integer: ");
        int userInt = Convert.ToInt32(Console.ReadLine());

        if (userInt > 0)
        {

            //validInt = true;
            SquareAndCubedTable(userInt);

        }
        else
        {
            //validInt = false;
            Console.WriteLine("select a positive and non zero number!");
        }



        Console.WriteLine("Would you like to go again? (y/n)");
        string cont = Console.ReadLine().ToLower();

         keepGoing = StartOver(cont);
    }

//}




static void SquareAndCubedTable(int x)
{
    Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
    Console.WriteLine("=======\t\t\t=======\t\t\t=======");

    for (int i = 1; i <= x; i++)
    {
        Console.WriteLine($"{i}\t\t\t{i * i}\t\t\t{i * i * i}");
    }
}

static bool StartOver(string a)
{

    if ( a == "yes")
    {
        return true;
    }
    else
    {
        return false;
    }
}
