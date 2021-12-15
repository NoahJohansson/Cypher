using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    abstract class Cipher : ICipher
    {
        public abstract string Encrypt(string input);

        public abstract string Decrypt(string input);

        public Cipher TheCaesarCipher1step {get; set;}
    }
}
