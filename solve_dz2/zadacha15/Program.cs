//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
            Console.WriteLine("Введите день недели");
            int day = Convert.ToInt32(Console.ReadLine());
            if ((day < 1) || (day > 7)) Console.WriteLine("Нет такого дня недели");    
            else
            {
                if (day >= 6) Console.WriteLine("да");
                else Console.WriteLine("нет");
            }
 