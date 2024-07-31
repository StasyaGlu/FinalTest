void Main()
{
    string[] arrayFirst = new string[] {"Hello", "my", "so", "happy", "world", ":-)", "!"};
    string[] arraySecond = new string[arrayFirst.Length];
    VerifOfElements(arrayFirst, arraySecond);
    PrintArray(arraySecond);

}

void VerifOfElements(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for(int i = 0; i < arrayFirst.Length; i++)
        if(arrayFirst[i].Length <= 3)
        {
            arraySecond[count] = arrayFirst[i];
            count++;
        }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }

    System.Console.WriteLine();
}

Main();
