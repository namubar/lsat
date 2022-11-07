int[] myArray = new int[8];
void ArrayPrint (int [ ] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: \t");
        myArray[i] = int.Parse(Console.ReadLine()!);
    }
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write("\t " + myArray[i] );
    }
}
ArrayPrint (myArray);