namespace dataSizes
{
    internal class Program
    {
        static void Main()
        {
            sbyte min = sbyte.MinValue;
            sbyte max = sbyte.MaxValue;
            sbyte size = sizeof(sbyte);
            Console.WriteLine($"The range of sbyte from {min} to {max} and size {size * 8} bit.\n");

            byte min1 = byte.MinValue;
            byte max1 = byte.MaxValue;
            byte size1 = sizeof(byte);
            Console.WriteLine($"The range of byte from {min1} to {max1} and size {size1 * 8} bit.\n");

            short min2 = short.MinValue; 
            short max2 = short.MaxValue;
            short size2 = sizeof(short);
            Console.WriteLine($"The range of short from {min2} to {max2} and size {size2 * 8} bit.\n");

            ushort min3 = ushort.MinValue;
            ushort max3 = ushort.MaxValue;
            ushort size3 = sizeof(ushort);
            Console.WriteLine($"The range of ushort from {min3} to {max3} and size {size3 * 8} bit.\n");

            int min4 = int.MinValue;
            int max4 = int.MaxValue;
            int size4 = sizeof(int);
            Console.WriteLine($"The range of int from {min4} to {max4} and size {size4 * 8} bit.\n");

            uint min5 = uint.MinValue;
            uint max5 = uint.MaxValue;
            uint size5 = sizeof(uint);
            Console.WriteLine($"The range of uint from {min5} to {max5} and size {size5 * 8} bit.\n");

            long min6 = long.MinValue;
            long max6 = long.MaxValue;
            long size6 = sizeof(long);
            Console.WriteLine($"The range of long from {min6} to {max6} and size {size6 * 8} bit.\n");

            ulong min7 = ulong.MinValue;
            ulong max7 = ulong.MaxValue;
            ulong size7 = sizeof(ulong);
            Console.WriteLine($"The range of ulong from {min7} to {max7} and size {size7 * 8} bit.\n");

            double min8 = double.MinValue;
            double max8 = double.MaxValue;
            double size8 = sizeof(double);
            Console.WriteLine($"The range of double from {min8} to {max8} and size {size8 * 8} bit.\n");

            decimal min9 = decimal.MinValue;
            decimal max9 = decimal.MaxValue;
            decimal size9 = sizeof(decimal);
            Console.WriteLine($"The range of decimal from {min9} to {max9} and size {size9 * 8} bit.\n");

            float min10 = float.MinValue;
            float max10 = float.MaxValue;
            float size10 = sizeof(float);
            Console.WriteLine($"The range of float from {min10} to {max10} and size {size10 * 8} bit.\n");

            char min11 = char.MinValue;
            char max11 = char.MaxValue;
            //char size11 = sizeof(char); // cannot implicitly convert type 'int' to 'char'.
            Console.WriteLine($"The range of char from {min11} to {max11}.");

        }
    }
}