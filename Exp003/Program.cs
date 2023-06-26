//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Clear();

 Console.Write("Введите номер дня недели:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n == 7 || n == 6) {
            Console.WriteLine($"День недели {n} выходной");
        }
        else if (n > 7) {
            Console.WriteLine($"Нет такого {n} дня в неделе");
        }
        else {
            Console.WriteLine($"День недели {n} будний день");
        }


