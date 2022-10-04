Console.Write("Введите целое число: ");
string userInput1 = Console.ReadLine() ?? "";
int N = int.Parse(userInput1);

int num = 1;

while (num < N)
{
    if (num % 2 == 0);
    {
        Console.WriteLine($"{num}");
        num++;  
    }
}
        
    
    