static void fun ()
{
        bool again = true;
    do
    {

        string[] name = { "Spongebob", "Patrick", "Squidward" };
        string[] hometown = { "pineapple", "rock", "totem head" };
        string[] favoriteFood = { "the SUNDAE", "Jellyfish Jam", "Krabby Patties" };
        Console.WriteLine($"Welcometo Mrs.Puff's Classroom! Which student would you like to learn more about? \nEnter a number 1-{name.Length} or enter 0 to see all students");
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer > 0){
            answer--;
            Console.WriteLine("Student " + (answer + 1) + " is " + name[answer] + ".\n " +
                "What would you like to know?  Enter \"hometown\" or \"favorite food\"");
            string answer2 = Console.ReadLine();
            string choice1 = "hometown home town Home Town Hometown HOME TOWN HOMETOWN h ht H HT";
            string choice2 = "favorite food Favorite Food FAVORITE FOOD ff FF f F";
            if (choice1.Contains(answer2))
            {
                Console.WriteLine(name[answer] + "'s hometown is a " + hometown[answer]);
            }
            else if (choice2.Contains(answer2))
            {
                Console.WriteLine(name[answer] + "'s favorite food is " + favoriteFood[answer]);
            }
            else
            {
                Console.WriteLine("try again!");
            }
            again = anotherOne();
        }
        else
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Student " + (i+1) + ": " + name[i]);
            }
                fun();
        }
    } while (again);
}

static bool anotherOne()
{
    Console.WriteLine("Would you like to hear about another student? yes or no");
    string answer3 = Console.ReadLine();
    if (answer3 == "yes" || answer3 == "y")
    {
        return true;
    }
    else
    {
        Console.WriteLine("Thanks for visiting Bikini Bottom!");
        return false;
    }
}

fun();