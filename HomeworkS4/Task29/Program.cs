// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
bool[] wasEntered = new bool[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Input the number #{i+1}: ");
    string str = Console.ReadLine();
    if(str == string.Empty)
    {
        array[i] = 0;
        wasEntered[i] = false;
    }
    else 
    {
        array[i] = int.Parse(str);
        wasEntered[i] = true;
    }
}


void PrintArray(int[] mass, bool[] enteredByUser)
{
    bool wasPrinted = false;
    for (int i = 0; i < mass.Length; i++)
    {
        if(enteredByUser[i])
        {
            if (wasPrinted)
            {
                Console.Write(", ");
            }
            wasPrinted = true;
            Console.Write($"{mass[i]}");
        }
    }
}

PrintArray(array, wasEntered);
