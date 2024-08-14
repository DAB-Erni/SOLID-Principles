using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
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
}
