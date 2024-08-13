using System;

public interface IEncryption
{
    string Encrypt(string data);
}

public class AESEncryption : IEncryption
{
    public string Encrypt(string data)
    {
        return "AES Encrypted data";
    }
}

public class RSAEncryption : IEncryption
{
    public string Encrypt(string data)
    {
        return "RSA Encrypted data";
    }
}

public class Encryption
{
    private readonly IEncryption _encryption;
    public Encryption(IEncryption encryption)
    {
        _encryption = encryption;
    }

    public string Encrypt(string data)
    {
        return _encryption.Encrypt(data);
    }
}


class Program
{
    static void Main(string[] args)
    {
        IEncryption aesEncrypt = new AESEncryption();
        Encryption encryption = new Encryption(aesEncrypt);
        string encryptedData = encryption.Encrypt("some data");
        Console.WriteLine(encryptedData);

        IEncryption rsaEncrypt = new RSAEncryption();
        encryption = new Encryption(aesEncrypt);
        encryptedData = encryption.Encrypt("some data");
        Console.WriteLine(encryptedData);

    }
}


//public abstract class Encryption
//{
//    public abstract void Encrypt(string data);
//}

//public class AESEncryption : Encryption
//{
//    public override void Encrypt(string data)
//    {
//        Console.WriteLine("AES Encrypted data: " + data);
//    }
//}

//public class RSAEncryption : Encryption
//{
//    public override void Encrypt(string data)
//    {
//        Console.WriteLine("RSA Encrypted data: " + data);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Encryption AESEncrypt = new AESEncryption();
//        Encryption RSAEncrypt = new RSAEncryption();

//        AESEncrypt.Encrypt("Sample Data for AES");
//        RSAEncrypt.Encrypt("Sample Data for RSA");

//    }
//}