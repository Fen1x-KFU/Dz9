using System;

namespace Tumakov
{
    public class Program
    {
        static void Task1()
        {
            ICipher aCipher = new ACipher();
            string originalString = "Hello World!";

            string encodedStrA = aCipher.Encode(originalString);
            Console.WriteLine("Encoded ACipher: " + encodedStrA);

            string decodedStrA = aCipher.Decode(encodedStrA);
            Console.WriteLine("Decoded ACipher: " + decodedStrA);

            ICipher bCipher = new BCipher();
            string originalStringB = "Hello World!";

            string encodedStrB = bCipher.Encode(originalStringB);
            Console.WriteLine("Encoded BCipher: " + encodedStrB);

            string decodedStrB = bCipher.Decode(encodedStrB);
            Console.WriteLine("Decoded BCipher: " + decodedStrB);
        }

        static void Main()
        {
            Task1();
            // Второй номер я так понял идёт только по составляющим, все составляющие в Классах и интерфейсах :)
        }
    }
}