//Метод void - метод без возвращения значений 
//(без использования оператора return)

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