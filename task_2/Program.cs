Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);


if (num1.Length > 2)
{
    if (num1[0] == num1[4] && num1[1] == num1[3])
    {
        Console.WriteLine(num1+ "-> число является палиндромом");
    }
    else 
    {
        Console.WriteLine(num1+ " -> число не является палиндромом");
    }
}