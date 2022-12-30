void PrintArray(string[] arr1)
{
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write("{0}\t", arr1[i]);
    }
    Console.WriteLine();
    
}

void ResultArray(string[] arr2)
{
    Console.WriteLine("Результат: ");
    string[] newarr = new string[arr2.Length];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i].Length <= 3)
        {
            newarr[i] = arr2[i];
            Console.Write("{0}\t", newarr[i]);
        }
    }
}

string[] array1 = { "work", "&^#", "gitHub", "123" };
string[] array2 = { "1234", "123", "tutu", "321", "7952..." };
string[] array3 = { "Яма", "рука", "гол", "шесть" };

PrintArray(array1);
ResultArray(array1);
Console.WriteLine();
Console.WriteLine();
PrintArray(array2);
ResultArray(array2);
Console.WriteLine();
Console.WriteLine();
PrintArray(array3);
ResultArray(array3);