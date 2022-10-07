Console.Clear();
int num;
{
while (true) 
    {
    Console.Write("Введите целое трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out num))
        break;
    Console.WriteLine($"Ошибка ввода");   
    }  
Console.Write(num +" -> ");
if (num <= 99 | num >= 1000)
    {
    Console.WriteLine("Ошибка ввода");
    } 
else if (num >= 100 && num <= 999)
    {
    num = num / 10 % 10;
    Console.WriteLine(num);
    } 
}