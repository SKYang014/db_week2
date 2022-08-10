// These two variables need to be accessed outside the loop
//string sentence = "";
//string word = "";

//do
//{
//	bool valid = false;

//	while (!valid)
//	{
//		Console.Write("Please enter a sentence: ");
//		sentence = Console.ReadLine();
//		if (sentence.Contains(" "))
//		{
//			valid = true;
//		}
//		else
//		{
//			Console.WriteLine("Make sure your sentence contains at least one space.");
//		}
//	}

//	valid = false;
//	while (!valid)
//	{
//		Console.Write("Please enter a word: ");
//		word = Console.ReadLine();

//		if (word.Contains(" "))
//		{
//			Console.WriteLine("Make sure you only enter a single word with no spaces.");
//		}
//		else
//		{
//			valid = true;
//		}
//	}

//	bool contains = sentence.ToLower().Contains(word.ToLower());
//	if (contains)
//	{
//		Console.WriteLine("Yup, that word exists in the sentence.");
//	}
//	else
//	{
//		Console.WriteLine("Nope, that word isn't found in the sentence.");
//	}

//} while (KeepGoing());

//Console.WriteLine("Thank you for playing!");



//static bool KeepGoing()
//{
//	while (true)
//	{
//		// Print out message asking if user wants to continue
//		Console.WriteLine("Would you like to test another sentence and word? (y/n)");
//		// Ask the user for their input
//		string response = Console.ReadLine();
//		response = response.ToLower();
//		// Check if they typed "y". If so, return true.
//		// Otherwise return false.   YES   yes
//		if (response == "y" || response == "yes")
//		{
//			return true;
//		}
//		else if (response == "n" || response == "no")
//		{
//			return false;
//		}
//		else
//		{
//			Console.WriteLine("Please enter y or n");
//		}
//	}
//}




//using System;

//namespace OverloadThatWorks
//{
//    internal class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("Hello World!");
//			Console.WriteLine(10);

//			int sum1 = Add(5, 3);
//			Console.WriteLine(sum1);
//			double sum2 = Add(5.5, 3.5);

//		}

//		// This is called overloading
//		static int Add(int x, int y)
//		{
//			return x + y;
//		}

//		static double Add(double x, double y)
//		{
//			return x + y;
//		}
//}
//}



//Console.WriteLine("Hello");
//Console.WriteLine(10);

//int sum1 = Add(5, 3);
//Console.WriteLine(sum1);

//double sum2 = Add(5.5, 3.5);

//static int Add(int x, int y)
//{
//	return x + y;
//}

//static double Add(double x, double y)
//{
//	return x + y;
//}






string sentence = "Hello there everybody from planet earth!";

string[] words = sentence.Split(); // noun dot verb, the noun is a variable, in this case sentence (string).

foreach (string word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine();
Console.WriteLine("Split by commas:");
sentence = "Hello,there,everybody,from,planet earth!";

char[] delims = { ',', ' ' }; // Split by comma or space
words = sentence.Split(delims);
foreach (string word in words)
{
    Console.WriteLine(word);
}

// Let's join these words back together

sentence = string.Join(';', words);
Console.WriteLine(sentence);

// Now let's try joining with spaces!

sentence = string.Join(' ', words); // noun dot verb, the noun is a type, in this case string. (Similar to int.Parse)
                                    // Methods that are attached to the type itself are called "static" methods.
                                    // Methods that are attached to an instance of the type (such as sentence) are called
                                    //     instance methods.
Console.WriteLine(sentence);

// Let's find the position of a letter in a string.
// IndexOf uses a common approach: It returns a 0-based index, or -1 if it doesn't find it.

Console.WriteLine();
Console.WriteLine("IndexOf Practice");
sentence = "We will find a letter position.";
Console.WriteLine(sentence.IndexOf('i'));
Console.WriteLine(sentence.IndexOf('x'));
Console.WriteLine(sentence.LastIndexOf('i'));
Console.WriteLine(sentence.LastIndexOf('x'));

// Let's use Substring to find a piece of a string
Console.WriteLine();
Console.WriteLine("Substring practice");
sentence = "Hello World";
Console.WriteLine(sentence.Substring(1));    // Expect "ello World"
Console.WriteLine(sentence.Substring(3));    // Expect "lo World"
Console.WriteLine(sentence.Substring(4, 3));  // Expect "o W"






//
// This example demonstrates two data structures: Stacks and Queues
//    (Different "stack" from the concept of stacks and heaps!)

Console.WriteLine("Let's do some stack practice!");

Stack<string> cards = new Stack<string>();

cards.Push("3D");
cards.Push("AS");
cards.Push("QH");
cards.Push("10D");

string next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

//next = cards.Pop();   If we pop again, we'll get a "stack empty" exception


Console.WriteLine();
Console.WriteLine("Now let's do some Queue practice.");

Queue<int> nums = new Queue<int>();
nums.Enqueue(5);  // 5 got there first
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

// Console.WriteLine(nums.Dequeue()); This line will throw an exception

Console.WriteLine();
Console.WriteLine("Advanced stack stuff");

cards.Clear();    // This empties out the stack. It clears it

cards.Push("5D");
cards.Push("JH");
cards.Push("3S"); // So far we have 5D on the bottom, JH next on top, and 3S at the very top

Console.WriteLine(cards.Pop());  // Expect 3S

// Let's just look at the top of the deck but not pull it off
string top = cards.Peek();
Console.WriteLine($"The top is {top} but we didn't remove it.");

// We didn't remove JH, so it's still there. So the next pop will be JH.

Console.WriteLine(cards.Pop());   // Expect JH

cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop());   // Expect KS

cards.Push("5D");

// Now let's draw them all off

Console.WriteLine("Let's draw all the rest of the cards!");
while (cards.Count > 0)
{
    next = cards.Pop();
    Console.WriteLine($"We just drew {next}.");
}

Console.WriteLine($"The count of the deck is now {cards.Count}"); // Expect to see 0