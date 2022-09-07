// 1 тип методов
/*
void Method1()
{
    Console.WriteLine("======================================");
    Console.WriteLine("это 1 тип метода, ничего не принимают и ничего не возвращают");
    Console.WriteLine("======================================");
}
Method1();
*/
// 2 тип методов
/*
void Method2(string msg)
{
    Console.WriteLine("======================================");
    Console.WriteLine(msg);
    Console.WriteLine("======================================");
}
Method2("это 2 тип метода, принимает, но не возвращает");
*/
// еще вариант второго типа методов
/*
void Method2_2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        i++;
        Console.WriteLine(msg);
    }
}
Method2_2("text",3);
Method2_2(count: 3, msg:"если именованые,то можно писать их не по порядку");
Console.WriteLine("======================================");
*/

// 3 тип методов
/*

int Method3()
{
   return DateTime.Now.Year;  
}
int year = Method3();

Console.WriteLine(year);
Console.WriteLine("======================================");
*/
// 4 тип методов
/*
string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while(i<count){
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "клей + ");
System.Console.WriteLine(res);
*/
/*
string Method5(int count, string c)
{
 
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + c; 
    }
    return result;
}
string res = Method5(10, "клей + ");
System.Console.WriteLine(res);
*/

// цикл for
/*
for (int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}");
    }
    System.Console.WriteLine();
}
*/
string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов,"
              + "а также будем использовать их на практике.";

string Replace(string text, char oldValue, char newValue)
{
    string res = string.Empty;
    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) res = res + $"{newValue}";
        else res = res + $"{text[i]}";

    }
    return res;
}
string newText = Replace(text, ' ' , '=');
System.Console.WriteLine(newText);
newText = Replace(text, 'п' , 'П');
System.Console.WriteLine(newText);