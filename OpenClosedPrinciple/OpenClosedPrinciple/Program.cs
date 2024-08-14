using System;
using OpenClosedPrinciple;

class Program
{
    static void Main(string[] args)
    {
        IEncryption aesEncrypt = new AESEncryption();
        Encryption encryption = new Encryption(aesEncrypt);
        string encryptedData = encryption.Encrypt("some data");
        Console.WriteLine(encryptedData);

        IEncryption rsaEncrypt = new RSAEncryption();
        encryption = new Encryption(rsaEncrypt);
        encryptedData = encryption.Encrypt("some data");
        Console.WriteLine(encryptedData);

    }
}
