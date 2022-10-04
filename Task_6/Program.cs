Console.Write("Введите целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);
if (a % 2 == 0)
{
    Console.Write($"{a} -> Число четное");
}
else
{
    Console.Write($"{a} -> Число нечетное");
}