// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = new string[] { "knowelege", "is", "a", "power", "42", "wow" };


void CreateArrayString(string[] args)
{
      Console.Write("|");
      for (int i = 0; i < array.Length; i++) 
      {
         if (i < array.Length - 1) Console.Write($"{array[i]} ");
         else Console.Write($"{array[i]}");
      }
      Console.WriteLine("|");
}

    
void SelectionSort(string[] array)
{	
    int maxWordLength = 3;
    Console.Write("| ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxWordLength) Console.Write($"{array[i]} ");
        
        
    }
    Console.WriteLine("|");
}

Console.WriteLine("Массив строк: ");
CreateArrayString(args);
Console.WriteLine();
Console.WriteLine("Массив строк после сортировки: ");
SelectionSort(array);