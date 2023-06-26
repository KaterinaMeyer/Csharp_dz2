//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Clear();

 Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int a = num;
int i = 1;
int thirdDigit = 0;
 int digitCount = num.ToString().Length;
if (num < 100){
    Console.WriteLine("Нет такой цифры");
}
else
{
   while (i <= digitCount) 
   {
        if (i == digitCount - 2) {
                thirdDigit = num % 10;
                break;
            }
     num /= 10;
     i++;
    }
}
int b = (num % 10);
Console.WriteLine($"Третья цифра в числе {a} равна {b}");






