namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 9" /*Вставь свой варик!*/ + Environment.NewLine + "Программа: Преобразования тип int в другие целочисленные типы");
            ConvertorIntToTypes.Convert(230); /*В скобках укажи свое число из варика!*/
            Console.WriteLine(Environment.NewLine + "Нажмите любую клавишу для завершения работы программы :)");
            Console.ReadKey();
        }
    }

    static class ConvertorIntToTypes
    {
        public static void Convert(int input)
        {
            Int16 input16 = (Int16)input;
            Int32 input32 = (Int32)input;
            Int64 input64 = (Int64)input;
            Byte inputByte = (Byte)input;
            sbyte inputSByte = (sbyte)input;

            PrintResult(input, input16, input32, input64, inputByte, inputSByte);
        }

        static void PrintResult(int i, Int16 i16, Int32 i32, Int64 i64, Byte iByte, sbyte iSByte)
        {
            Console.WriteLine(Environment.NewLine 
                + "Типы     {0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", "Int", "Int16", "Int32", "Int64", "Byte", "SByte");

            Console.WriteLine("Значения {0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", i, i16 ,i32, i64, iByte, iSByte);
            Console.WriteLine("Байты    {0,8}{1,8}{2,8}{3,8}{4,8}{5,8}", sizeof(int), sizeof(Int16), sizeof(Int32), sizeof(Int64), sizeof(Byte), sizeof(sbyte));
        }
    }
}
