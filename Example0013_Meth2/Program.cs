//Методы
// 1) ничего не принимают, ничего не возвращают
// 2) что-то принимают, ничего не возвращают
// 3) ничего не принимают, что-то возвращают
// 4) чего-то принимают, что-то возвращают

//Вид 1  (void)

/*
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();
*/

//Вид 2   (void)

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
*/

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
//Другие способы вызова метода:
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "новый текст" );
*/

//Вид 3   (return)

/*
int Method3()
{

    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

//Вид 4    (return)

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Wow! ");
Console.WriteLine(res);
*/


// Цикл for 
//Собирает в себе все - условия, счетчики, и т.д.
// for (int i = 0, i < 10, i++)
//  {
//      Console.WriteLine(i)
//  }

/*
string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Wow! ");
//Console.WriteLine(res);
*/

//Цикл в цикле
// for (int i =0; i < 10; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        Console.WriteLine(i*j)
//    }
//    Console.WriteLine()
//}

//Вывод таблицы умножения

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++);
    {
        Console.WriteLine($" {i} x {j} = {i*j}");
    }
    Console.WriteLine();                    //переход на новую строку после цикла с каждым числом
}
*/


//Работа с текстом
//Дан текст. Втексте нужно все пробелы заменить черточками, 
//маленькие буквы "к" заменить болшими "К", 
//а большие "С" заменить маленькими "с".
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012..
// s(3) // r

string Replace( string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С', 'с');
*/

//Массивы в методах
//Алгоритм сортировки методом выбора

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void Printarray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++ )
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

Printarray(arr);
SelectionSort(arr);

Printarray(arr);