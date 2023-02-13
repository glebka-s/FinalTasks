string[] CreateStringArray(int N)
{
    string[] array = new string[N];
    int i = 0;
    while (i < N)
    {   
        string a = Console.ReadLine();
        array[i] = a;
        i++;
    }
    return(array);
}

void PrintArray(string[] array)
{
    int len = array.Length;
    if (len > 0)
    {
        Console.Write($"['{array[0]}'");
        int i = 1;
        while (i < len)
        {
            Console.Write($", '{array[i]}'");
            i++;
        }
        Console.Write("]");
    }
    else
        Console.Write("[]");
}

int GetIntPosNumberFromUser(string message, string ErrorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
        {
            if (UserNumber > 0)
                return UserNumber;
        }
        Console.WriteLine(ErrorMessage);
    }
}


int N = GetIntPosNumberFromUser("Введите количество элементов массива:", "Ошибка вввода!");
string[] array = CreateStringArray(N);

int len = 0;
for (int i = 0; i < N; i++)
{
    if (array[i].Length <= 3)
        len ++;
}

string[] result = new string[len];

int j = 0;
for (int i = 0; i < N; i++)
{
    if (array[i].Length <= 3)
    {
        result[j] = array[i];
        j ++;
    }
}

PrintArray(array);
Console.Write(" -> ");
PrintArray(result);