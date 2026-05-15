namespace TaskThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 9" /*Номер варика поменяй!*/ + Environment.NewLine + "Преобразование типа double в типы Single и Int");
            ConvertDoubleToTypes.Convert(91.012); /*Вставь в скобки число из вашего варика!*/
            Console.WriteLine(Environment.NewLine + "Нажмите любую клавишу для завершения работы программы :)");
            Console.ReadKey();
        }
    }

    static class ConvertDoubleToTypes
    {
        public static void Convert(double input)
        {
            Single inputSin = (Single)input;
            int inputInt = (int)input;

            PrintResult(input, inputSin, inputInt);
        }

        static void PrintResult(double i, Single iSin, int iInt)
        {
            Console.WriteLine(Environment.NewLine
                + "Типы     {0,8}{1,8}{2,8}", "Double", "Single", "Int");

            Console.WriteLine("Значения {0,8}{1,8}{2,8}", i, iSin, iInt);
            Console.WriteLine("Байты    {0,8}{1,8}{2,8}", sizeof(double), sizeof(Single), sizeof(int));
        }
    }
}
