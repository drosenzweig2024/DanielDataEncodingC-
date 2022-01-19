using System;
namespace DanielDataEncodingC_
{
    class Program
    {
         static void Main(string[] args)
        {
            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'.");

            Cipher cipher;
            cipher = new Cipher(5);

            Cipher cipher2;
            cipher2 = new Cipher(3);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            //Console.WriteLine($"The encrypted message is: '{encrypted}'");

            string decrypted;
            decrypted = cipher.Decrypt(encrypted);
            //Console.WriteLine($"The decrypted message is: '{decrypted}'");

            string message;
            message = System.IO.File.ReadAllText(filePath);
            //Console.WriteLine($"The encrypted message is: '{message}'.");

            //decrypted = cipher2.Decrypt(message);
            //Console.WriteLine($"The decrypted message is: '{decrypted}'");

            int shift;
            shift = 1;
            while (shift <= 10)
            {
                Cipher cipher3;
                cipher3 = new Cipher(shift);
                decrypted = cipher3.Decrypt(message);
                Console.WriteLine($"The decrypted message is: '{decrypted}'");
                shift += 1;
            }
        }
    }
}
