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
        static string EncryptDecrypt(string input)
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

        static void Main(string[] args)
        {
            string msg = Console.ReadLine().ToLower();

            string encrypted = EncryptDecrypt(msg);

            Console.WriteLine(encrypted);

            string path = @"C:\Users\User\OneDrive\Desktop\secret.txt";

            File.WriteAllText(path,  encrypted);

            string readFromFile = File.ReadAllText(@"C:\Users\User\OneDrive\Desktop\secret.txt");

            Console.Write(EncryptDecrypt(readFromFile));
        }
    }
}
