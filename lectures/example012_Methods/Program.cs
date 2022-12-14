// Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}

//Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст сообщения", count: 4);

// 3 Вид

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// 4 Вид

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result += c;
//         i++;
//     } 
//     return result;
// }

// string res = Method4(10, "asdf");
//Console.WriteLine(res);


// for

// string Method5(int count, string c)
// {
    
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result += c;
//     } 
//     return result;
// }

// string res = Method5(10, "asdf");
// Console.WriteLine(res);

//таблица умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//==== Работа с текстом
// Дан текст. Втексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К"б
// а большие "С" заменить маленькими "с"

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


// Алгоритм сортировки выбором

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

