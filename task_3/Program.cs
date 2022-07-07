// напишите программу, которая принимает на вход число N и выдает таблицу кубов от 1 до N

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());



int n =1;
int square = 0;

    for (int i = 0; i < num; i++)
   {

    square = n * n * n;
    
    Console.Write("{0}  ",(square));
    n = n + 1;

       
   }