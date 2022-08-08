Random ran = new Random();

for (int i = 0; i <= 25; i++)
{
    int num = ran.Next(1,7);
    int num2 = ran.Next(1, 7);
    Console.WriteLine(num + " and " + num2);
}