//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.
int j=0;
int [] Array = new int [10];
int [] EventArray = new int [10];
void PrintArray (int [] Array)  // Создание и распечатывание массива
{
    for(int i=0; i<Array.Length; i++)
    {
        Array[i]=new Random().Next(-50,50);
        Console.Write($"{Array[i]} ");
    }
}
void GetArray (int [] EvenArray)
{
    for(int i=0; i<Array.Length; i++)
    {
        if(Array[i]%2==0)
        {
            EvenArray[j]=Array[i];
            Console.Write($"{EvenArray[j]} ");
            j++;
        }
        
    }
}
Console.WriteLine("Массив из целых чисел");
PrintArray(Array);
Console.WriteLine();
Console.WriteLine("Массив из четных чисел");
GetArray(EventArray);