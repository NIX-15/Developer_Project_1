Console.Write("Input the number L(Array Lenght): ");
int L = int.Parse(Console.ReadLine()!);
while (L < 1) 
{
    Console.Write("Error! Wrong Input! Input L again: ");
    L = int.Parse(Console.ReadLine()!);
}
string[] arrOld = new string[L]; 
void fillArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter the value of the element {i + 1}: ");
        arr[i] = Console.ReadLine()!;
    }
}
string[] arrNew(string[] arrOld)
{
    int s = arrOld.Length;
    for (int i = 0; i < arrOld.Length; i++)
    {
        if (arrOld[i].Length > 3)
            s--;
    }
    if (s == 0)
    {
        string[] arrNew = new string[1];
        arrNew[0] = " No elements whose length is at least 3 ";
        return arrNew;
    }
    else
    {
        string[] arrNew = new string[s];
        s = 0;
        for (int i = 0; i < arrOld.Length; i++)
        {
            if (arrOld[i].Length < 4)
            {
                arrNew[s] = arrOld[i];
                s++;
            }
        }
        return arrNew;
    }
}
void displayArr(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"\"{arr[i]}\" ");
    Console.Write("]");
    Console.WriteLine();
}
fillArr(arrOld);
displayArr(arrOld);
Console.WriteLine("Result: ");
displayArr(arrNew(arrOld));