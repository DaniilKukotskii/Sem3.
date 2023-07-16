void kub(int num)
{
    for (int i = 1; i <= num; i++)
    {
    int num1 = i * i * i;
    Console.WriteLine(num1 + " ");
    }
}

Console.Write("Enter your number:");
int num1 = Convert.ToInt32(Console.ReadLine());
kub(num1);