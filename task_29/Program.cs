/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */




/*int[] RandomArray ()
{
    int[] array1 = new int[8];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-999,1000);
    }
    return array1;
}

Console.WriteLine ("массив из 8 элементов : ");
Console.Write(String.Join(" ", RandomArray()));
*/

void array1(){
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(1,100);
    }
    Console.WriteLine("[{0}]", string.Join(", ", arr));
}
Console.WriteLine("Массив из 8 элементов");
array1();
Console.WriteLine();