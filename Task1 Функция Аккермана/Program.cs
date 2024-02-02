using System.Numerics;

Console.WriteLine("Введите 1-ое неотрицательное число: ");
string input1 = Console.ReadLine();
Console.WriteLine("Введите 2-ое неотрицательное число: ");
string input2 = Console.ReadLine();
BigInteger n = BigInteger.Parse(input1);
BigInteger m = BigInteger.Parse(input2);
Console.WriteLine($"Функция Аккермана А({n}, {m}) = {Ack(n, m)}");

static BigInteger Ack(BigInteger num1, BigInteger num2)
{
    if (num1 == 0)
    {
        return BigInteger.Add(num2,1);
    }
    else if (num2 == 0)
    {
        return Ack(BigInteger.Subtract(num1,1), 1);
    }
    else
    {
        return Ack(BigInteger.Subtract(num1,1), Ack(num1, BigInteger.Subtract(num2,1)));
    }
}
