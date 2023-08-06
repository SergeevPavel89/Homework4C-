// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



// int prompt(string massage)
// {
// Console.WriteLine(massage);

// string readinput=Console.ReadLine();
// int result= int.Parse(readinput);

// return result;

// }

// int power(int powerBase, int exponent)
// {
//     int power =1;
//     for(int i=0; i<exponent; i++)
//     {
//         power*=powerBase;
//     }
//     return power;

// }
// bool ValideteExponent(int exponent)
// {
//     if (exponent<0)
//     {
//         Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }

// int powerBase= prompt("ВВедите осование:");
// int exponent= prompt("ВВедите осование:");
// if (ValideteExponent(exponent))
// {
//     Console.WriteLine($"Число {powerBase} в степени{exponent} равно{power( powerBase, exponent)}");
// }

// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int prompt(string massage)
// {
//     Console.WriteLine(massage);
//     string readinput=Console.ReadLine();
//     int result= int.Parse(readinput);

// return result;
// }
// int SumAllDigit(int number)
// {
//     int result =0;
//     while (number>0)
//     {
//        result +=number%10;
//        number=number/10; 
//     }
//     return result;
// }
// int number= prompt("Введите число");
// Console.WriteLine($"Сумма всех чисел в {number}= {SumAllDigit(number)}");

// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}