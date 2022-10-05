Console.Write("Введите число : ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до " + n);
int i = 1;
while (i <= n)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}
    