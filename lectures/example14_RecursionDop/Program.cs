// Собрать строку с числами от a до b, a <= b

// Without recursion
string NumberFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";    
    }
    return result;
}

// With recursion
string NumberRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumberRec(a + 1, b); 
    else return string.Empty;
}

// Console.WriteLine(NumberFor(1, 10));
// Console.WriteLine(NumberRec(1, 10));


// Сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));


// Факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if ( n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));


// Вычислить a в степени n
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    // if ( n == 0) return 1;
    // else return a * PowerRec(a, n - 1);
    return n == 0 ? 1 : a * PowerRec(a, n - 1);
}

int PowerRecMath(int a, int n)
{
    if ( n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));


// Пусть у нас будет некоторый алфавит, состоящий из
// четырёх букв "a", "и", "с", "в", и нас просят показать все возможные слова, состоящие из T букв. Т может
// равняться 1, 2, 3 и так далее.

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

// FindWords("аисв", new char[3]);


// Перебор папок
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = @"D:\GeekBrains\С#\examples\C_hello_code\lectures\example001_Hello_Console";
// CatalogInfo(path);


// Игра пирамидки
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

// Towers();

// Обход деревьев
string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                0    1    2    3     4    5    6    7    8    9    10   11
void InOderTravelsal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOderTravelsal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOderTravelsal(right);
    }
}

// InOderTravelsal();








