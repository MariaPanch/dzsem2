// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
            Console.WriteLine("Введите трехзначное число");
            int num = Convert.ToInt32(Console.ReadLine());
            int tmp = num / 10;
            num = tmp%10;
            Console.WriteLine(num);           
 