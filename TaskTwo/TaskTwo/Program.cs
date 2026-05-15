using System.ComponentModel;

namespace TaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 9" /*Вставь свой варик!*/ + Environment.NewLine + "Преобразование типа Int в типы с плавающей запятой");
            ConvertorIntToFloatTypes.Convert(230); /*Вставь число из своего варика!*/
            Console.WriteLine(Environment.NewLine + "Нажмите на любую клавишу для завершения работы программы :)");
            Console.ReadKey();
        }
    }

    static class ConvertorIntToFloatTypes
    {
        public static void Convert(int input)
        {
            decimal inputDec = (decimal)input;
            Single inputSin = (Single)input;
            double inputDou = input;

            PrintResult(input, inputDec, inputSin, inputDou);
        }

        static void PrintResult(int i, decimal iDec, Single iSin, double iDou)
        {
            Console.WriteLine(Environment.NewLine
                + "Типы     {0,8} {1,8} {2,8} {3,8}", "Int", "Decimal", "Single", "Double");

            Console.WriteLine("Значения {0,8} {1,8} {2,8} {3,8}", i, iDec, iSin, iDou);
            Console.WriteLine("Байты    {0,8} {1,8} {2,8} {3,8}", sizeof(int), sizeof(Decimal), sizeof(Single), sizeof(Double));
        }
    }
}
