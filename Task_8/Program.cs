Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int N = int.Parse(userInput);

int a = 1;

while (a < N + 1)
{
    if (a % 2 == 0)
    {
        Console.WriteLine($"{a}");
    }
    a++;
}