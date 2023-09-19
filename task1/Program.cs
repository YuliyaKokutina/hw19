/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int count = 0;
int [] Convert(string message)
{
System.Console.WriteLine($"{message}");
string stroka = Console.ReadLine();
string [] str = stroka.Split(", ");
int [] arr = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    arr[i]=int.Parse(str[i]);
}
return arr;
}
int [] array = Convert("Введите числа");

int Totalizer(int [] array)
{

for (int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    {count++;}
}
return count;
}
count = Totalizer(array);
System.Console.WriteLine(count);
