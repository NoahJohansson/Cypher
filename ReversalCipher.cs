using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    class ReversalCipher : Cipher
    {
        public string chiffer { get; set; }

        public ReversalCipher(string _chiffer) : base(_chiffer)
        {
        }
        /// <summary>
        /// Encrypt för Reversal. Gör string till char array för att kunna använda inbyggda metoden Reverse(). Decrypt metoden gör exakt samma sak.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string Encrypt(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public override string Decrypt(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
        
    }
}
