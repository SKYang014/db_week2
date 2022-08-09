
////array
//string[] myarr = { "abc", "def", "ghi" };

//Console.WriteLine(myarr[0]);

//myarr[1] = "jkl";

//for (int i = 0; i < myarr.Length; i++)
//{
//    Console.WriteLine(myarr[i]);
//}
//Console.WriteLine();

////list
//List<string> myList = new List<string>();
//myList.Add("Abc");
//myList.Add("Efg");
//myList.Add("Ghi");

//Console.WriteLine(myList[0]);

//myList[1] = "Jkl";

//myList.Add("Mno");

//for (int i = 0; i < myList.Count; i++)
//{
//    Console.WriteLine(myList[i]);
//}

//Console.WriteLine("remove index 2");
//myList.RemoveAt(3);
//for (int i = 0; i < myList.Count; i++)
//{
//    Console.WriteLine(myList[i]);
//}

////myList.Add("Abc");
////myList.Add("Abc");

//Console.WriteLine("let's remove one by name: Abc");
//myList.Remove("Abc");
//for (int i = 0; i < myList.Count; i++)
//{
//    Console.WriteLine(myList[i]);
//}

/////xxx here yyy

//Console.WriteLine("Now let's insert one in between the first two");
//myList.Insert(1, "Pqr");
//foreach (string word in myList)
//{
//    Console.WriteLine(word);
//}

//Console.WriteLine("lets sort the list");
//myList.Sort();
//foreach (string word in myList)
//{
//    Console.WriteLine(word);
//}

////let check if one exists
//Console.WriteLine("type in a word and we'll see if its in the list");
//string entry = Console.ReadLine();
//int index = myList.IndexOf(entry);
//if (index >= 0)
//{
//    Console.WriteLine($"found {entry} at {index}");
//}
//else//index of will return -1 if not found
//{
//    Console.WriteLine($"sorry {entry} not found.");
//}

//list for comparison
//List<string> letters = new List<string>();
//letters.Add("Abc");
//letters.Add("Def");
//letters.Add("Hhi");
//letters.Add("Jkl");
//letters.Add("Mno");

//Console.WriteLine("here are the letters");
//foreach ( string next in  letters)
//{
//    Console.WriteLine(next);
//}

//Dictionary<string, string> foods = new Dictionary<string, string>();
//foods["Paul"] = "Spaghetti";
//foods["Sarah"] = "Pizza";
//foods["Quincy"] = "Tacos";
//foods["Ruby"] = "Ice Cream";
//foods["Tery"] = "Tacos";

////printing out results
//Console.WriteLine("here is ruby's fav food");
//Console.WriteLine(foods["Ruby"]);

////Paul changed his mind
//foods["Paul"] = "Hamburgers";
//Console.WriteLine($"Paul now likes {foods["Paul"]}");

//foreach (var pair in foods)
//{
//    Console.WriteLine("the name and the food are:");
//    Console.WriteLine(pair.Key);//name
//    Console.WriteLine(pair.Value);//fav food
//}


////check if items exsists in the dictionary

//string entry = Console.ReadLine();
//if (foods.ContainsKey(entry))
//{
//    Console.WriteLine($"Yes, we have a favorite food for {entry}");
//    Console.WriteLine(foods[entry]);
//}
//else
//{
//    Console.WriteLine("we dont know that person");
//}


Dictionary<string, decimal> salaries = new Dictionary<string, decimal>();
salaries["apple"] = 0.99m;
salaries["banana"] = 0.59m;
salaries["cauliflower"] = 1.59m;
salaries["dragonfruit"] = 2.19m;
salaries["elderberry"] = 1.79m;
salaries["figs"] = 2.09m;
salaries["grapefruit"] = 0.59m;
salaries["honeydew"] = 0.99m;

Console.WriteLine("please add a new employee\nEnter their name: ");
string name = Console.ReadLine();

Console.WriteLine("please enter their salary:");
string answer = Console.ReadLine();
decimal salary = decimal.Parse(answer);

salaries[name] = salary;
Console.WriteLine("here is everybody: ");
foreach (var pair in salaries)
{
    Console.WriteLine($"{pair.Key} makes {pair.Value}");
}