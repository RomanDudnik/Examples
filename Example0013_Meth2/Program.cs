﻿//Методы
// 1) ничего не принимают, ничего не возвращают
// 2) что-то принимают, ничего не возвращают
// 3) ничего не принимают, что-то возвращают
// 4) чего-то принимают, что-то возвращают

//Вид 1

/*
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();
*/

//Вид 2

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

