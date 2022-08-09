//dice/randome roller
//Random ran = new Random();

//for (int i = 0; i <= 25; i++)
//{
//    int num = ran.Next(1, 7);
//    int num2 = ran.Next(1, 7);
//    Console.WriteLine(num + " and " + num2);
//}


//TryParse
//while (true)
//{

//    Console.WriteLine("Please enter an integer");

//    string entry = Console.ReadLine();
//    int num;

//    bool result = int.TryParse(entry, out num);
//    if (result)
//    {
//        Console.WriteLine($"Great, your number is {num}");
//    }
//    else
//    {
//        Console.WriteLine($"Oops, {entry} is not an interger");
//    }
//}



//Arrays
//an array is a variable that can hold a list of things

int[] grades = {100, 80, 60, 100};
Console.WriteLine(grades[0]);
Console.WriteLine(grades[1]);
Console.WriteLine(grades[2]);


string[] names = { "Fred", "Jamal", "Yasmine", "Ziggy"};

Console.WriteLine();
int index = 3;
Console.WriteLine(names[index]);

Console.WriteLine();
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(names[i]);
}
names[2] = "Jasmine";
Console.WriteLine();
Console.WriteLine($"We changed the spelling of {names[2]}");

grades[0] = 99;
Console.WriteLine($"the first grade is now {grades[0]}");


for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{names[i]} has grade {grades[i]}");
}

//Version 1
//Console.WriteLine();
//Console.WriteLine("Please enter a number from 1 - 5");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//num--;
//Console.WriteLine($"{names[num]} has grade {grades[num]}");

//Version 2

//bool okay = false;
//while (okay == false)
//{
//    Console.WriteLine();
//    Console.WriteLine("PLease enter a number from 1 - 5");
//    string entry = Console.ReadLine();
//    int num;
//    okay = int.TryParse(entry, out num);
//if (okay)
//{
//    num--;
//    Console.WriteLine($"{names[num]} has grade {grades[num]}");
//} 
//}

