//Работа с массивами
/*
//1)

int Max (int arg1, int arg2, int arg3)   //Поиск максимума из трех (добавили три аргумента)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;                     // возвращение result
} //             0   1   2   3   4   5   6   7   8  
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };       //Добавим массив
array[0] = 12;                               //Обращение к масиву для записи в него значения
Console.WriteLine(array[0]);          //Обращение к массиву для получения значения соответсвующего элемента по указаному индексу массива
*/

//2)

int Max (int arg1, int arg2, int arg3)   //Поиск максимума из трех (добавили три аргумента)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;                     // возвращение result
} //             0    1   2   3   4   5   6   7   8  
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };       //Добавим массив

int max = Max(                                 //так-же функция с массивом
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);