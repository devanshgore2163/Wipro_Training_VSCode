string[] str = new string[2];
str[0]="Mom";
str[1]="Dad";
for(int i = 0; i < str.Length; i++)
{
    Console.WriteLine($"The strings at {i} is {str[i]}");
}
Console.WriteLine($"The count of strings are {str.Count()}");
