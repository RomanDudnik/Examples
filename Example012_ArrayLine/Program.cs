//Метод void - метод без возвращения значений 
//(без использования оператора return)
/*
void FillArray(int[] collection)           //void метод ; (int[] collection) аргумент с названием collection
{
    int length = collection.Length;         //получить длинну массива
    int index = 0;                  //начальная позиция
    while (index < length)            //цикл
    {
        collection[index] = new Random().Next(1, 10);     //вкладываем новое рандом число в аргумент из диапазона Next(1, 10)   
        index++;
    }
}

void PrintArray(int[] col)             //Метод который печатает массив; другой метод с другим названием аргумента
{
    int count = col.Length;             //другие названия
    int position = 0;                   //другие названия
    while (position < count)              //другие названия
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];   //Создадим массив из [10] элементов; конструкция new int[10] - создание массива из [10] эл-ов

FillArray(array);         
PrintArray(array);       
*/

//Доработка предыдущей задачи

void FillArray(int[] collection)           //void метод ; (int[] collection) аргумент с названием collection
{
    int length = collection.Length;         //получить длинну массива
    int index = 0;                  //начальная позиция
    while (index < length)            //цикл
    {
        collection[index] = new Random().Next(1, 10);     //вкладываем новое рандом число в аргумент из диапазона Next(1, 10)   
        index++;
    }
}

void PrintArray(int[] col)             //Метод который печатает массив; другой метод с другим названием аргумента
{
    int count = col.Length;             //другие названия
    int position = 0;                   //другие названия
    while (position < count)              //другие названия
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)  //Метод возвращения позиции
{
    int count = collection.Length;          //кол-во эл-ов
    int index = 0;
    int position = -1;         //вместо int position = 0, указываем -1 если запрашиваемого элемента нет в массиве (будет вывод -1)
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
        return position;
}

int[] array = new int[10];   //Создадим массив из [10] элементов; конструкция new int[10] - создание массива из [10] эл-ов

FillArray(array);         
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);