using System.Text;

namespace Decoder
{
    internal class Crypto
    {
        public static string Encrypt(string unencrypted)
        {
            char[] chars = unencrypted.ToCharArray();
            int asciiSum = 0;
            string encryptionVariant = string.Empty;

            foreach (char c in chars)
            {
                asciiSum += c;
            }

            if (asciiSum % 5 == 0)
            {
                encryptionVariant = "A";
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = (char)(chars[i] + (i + 5));
                }
            }
            else if (asciiSum % 3  == 0)
            {
                encryptionVariant = "B";
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = (char)(chars[i] + (i + 3));
                }
            }
            else
            {
                encryptionVariant = "C";
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = (char)(chars[i] + (i + 1));
                }
            }
            string final = encryptionVariant + new string(chars);
            return final;
        }
        public static string Decrypt(string encrypted)
        {
            char[] chars = encrypted.ToCharArray();
            StringBuilder sb = new StringBuilder();

            if (chars[0] == 'A')
            {
                for (int i = 1; i < chars.Length; i++)
                {
                    sb.Append((char)(chars[i] - (i - 1 + 5)));
                }
            }
            else if (chars[0] == 'B')
            {
                for (int i = 1; i < chars.Length; i++)
                {
                    sb.Append((char)(chars[i] - (i - 1 + 3)));
                }
            }
            else
            {
                for (int i = 1; i < chars.Length; i++)
                {
                    sb.Append((char)(chars[i] - i));
                }
            }
            return sb.ToString();
        }
    }
}
