string orig = "The quick brown fox jumps over the lazy dog."; // C
//string orig = "The quick brown fox jumps over Dan."; // B
//string orig = "Dan kicked the fox."; //A
string encrypted = Decoder.Crypto.Encrypt(orig);
string decrypted = Decoder.Crypto.Decrypt(encrypted);
Console.WriteLine(orig);
Console.WriteLine(encrypted);
Console.WriteLine(decrypted);
