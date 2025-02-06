using System;

namespace VigenereEncrypt
{
    public class VigenereCipher
    {
        public static void Main()
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Choose an option: \n1. Encrypt text\n2. Decrypt text\n3. Exit\n");
                string choice = Console.ReadLine() ?? "";

                if (choice == "1")
                {
                    Console.Write("Enter text: ");
                    string text = Console.ReadLine() ?? string.Empty;

                    Console.Write("Enter keyword: ");
                    string keyword = Console.ReadLine() ?? string.Empty;

                    string encrypted = Encrypt(text, keyword);
                    Console.WriteLine("Encrypted: " + encrypted);
                }
                else if (choice == "2")
                {
                    Console.Write("Enter text: ");
                    string text = Console.ReadLine() ?? string.Empty;

                    Console.Write("Enter keyword: ");
                    string keyword = Console.ReadLine() ?? string.Empty;

                    string decrypted = Decrypt(text, keyword);
                    Console.WriteLine("Decrypted: " + decrypted);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please enter 1, 2, or 3.\n");
                }
            }
        }

        public static string Encrypt(string text, string key)
        {
            string result = "";
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    bool isLower = char.IsLower(c);
                    char baseChar = isLower ? 'a' : 'A';

                    int shift = key[keyIndex] - 'A';
                    char encryptedChar = (char)(((c - baseChar + shift) % 26) + baseChar);
                    result += encryptedChar;

                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result += c; // Keep spaces and punctuation
                }
            }
            return result;
        }

        public static string Decrypt(string text, string key)
        {
            string result = "";
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    bool isLower = char.IsLower(c);
                    char baseChar = isLower ? 'a' : 'A';

                    int shift = key[keyIndex] - 'A';
                    char decryptedChar = (char)(((c - baseChar - shift + 26) % 26) + baseChar);
                    result += decryptedChar;

                    keyIndex = (keyIndex + 1) % key.Length;
                }
                else
                {
                    result += c; // Keep spaces and punctuation
                }
            }
            return result;
        }

        
    }
}
