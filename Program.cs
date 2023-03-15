System.Console.Write("Enter a string: ");
string input = Console.ReadLine()!;
input = input.ToLower();

System.Console.Write("Enter a char: ");
char character = char.Parse(Console.ReadLine()!);

bool IsContained = Contains(input, character);
System.Console.WriteLine(IsContained);

bool Contains(string input, char character)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == character)
        {
            return IsContained = true;
        }
    }
    return IsContained = false;;
}