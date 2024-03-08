Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for (int i = 0; i < number; number /= 2)
{

    if (number % 2 == 0)
    {
        list.Add(0);
    }
    else if (number % 2 == 1)
    {
        list.Add(1);
    }
}
list.Reverse();
foreach (int i in list)
{
    Console.Write(i);
}