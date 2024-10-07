#region Task1
Console.WriteLine("Enter radius");
int radius = int.Parse(Console.ReadLine());
int diff = 4 * radius * radius - 2 * radius * radius;
Console.WriteLine(diff);
#endregion

#region Task2
string[] array = new string[] { "X", "X", "Y" };
for (int ind = 1; ind < array.Length; ind++)
{
    if (array[0] != array[ind])
    {
        Console.WriteLine("NO");
        return;
    }
}
Console.WriteLine("YES");
#endregion

#region Task3
int winScore = 3;
int winEqual = 1;
int losScore = 1;
Console.WriteLine("Tell me the counts");
int win = int.Parse(Console.ReadLine());
int eq = int.Parse(Console.ReadLine());
int lose = int.Parse(Console.ReadLine());
int totalScore = win * winScore + eq * winEqual + lose * losScore;
Console.WriteLine($"The total score is {totalScore}");
#endregion

#region Task4
const int weekDays = 7;
int[] hours = new int[weekDays] { 5, 8, 8, 8, 8, 8, 8 };
int totalMoney = 0;
for (int h = 0; h < weekDays; h++)
{
    if (h < weekDays - 2 & hours[h] <= 8)
    {
        totalMoney += hours[h] * 10;
    }
    else if (h < weekDays - 2 & hours[h] > 8)
    {
        totalMoney += hours[h] * 15;
    }
    else if (h >= weekDays - 2 & hours[h] <= 8)
    {
        totalMoney += hours[h] * 20;
    }
    else if (h >= weekDays - 2 & hours[h] > 8)
    {
        totalMoney += hours[h] * 30;
    }
}
Console.WriteLine($"The total money is {totalMoney}");
#endregion

#region Task5
Console.WriteLine("The number of practise days: ");
int days = int.Parse(Console.ReadLine());
int[] practise = new int[days];
for (int pr = 0; pr < days; pr++)
{
    practise[pr] = int.Parse(Console.ReadLine());
}
int min = practise[0];
int betterDays = 0;
foreach (int d in practise)
{
    if (d > min)
    {
        min = d;
        betterDays++;
    }
}
Console.WriteLine(betterDays);
#endregion

#region Task5
Console.WriteLine("Write the length of word");
int sizeWord = int.Parse(Console.ReadLine());
Console.WriteLine("Now write the length of the array");
int sizeArray = int.Parse(Console.ReadLine());
string[] str = new string[sizeArray];
for (int word = 0; word < sizeArray; word++)
{
    str[word] = Console.ReadLine();
}
int count = 0;
foreach (string s in str)
{
    if (s.Length == sizeWord)
    {
        Console.WriteLine(s);
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("No elements found");
}
#endregion