using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherEncrypt
{
    internal class Program
    {
        static string Encrypt(string input)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";

            string encrypted = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    encrypted += letters[letters.Length - letters.IndexOf(input[i]) - 1].ToString();
                }
                else
                {
                    encrypted += input[i].ToString();
                }
            }
            return encrypted;
        }

        static string Decrypt(string input)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";

            string decrypted = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    decrypted += letters[letters.Length - letters.IndexOf(input[i]) - 1].ToString();
                }
                else
                {
                    decrypted += input[i].ToString();
                }
            }
            return decrypted;
        }

        static void Main(string[] args)
        {
            string msg = Console.ReadLine().ToLower();

            string encrypted = Encrypt(msg);

            Console.WriteLine(encrypted);

            string path = @"C:\Users\User\OneDrive\Desktop\secret.txt";

            File.WriteAllText(path,  encrypted);

            string readFromFile = File.ReadAllText(@"C:\Users\User\OneDrive\Desktop\secret.txt");

            Console.Write(Decrypt(readFromFile));
        }
    }
}
