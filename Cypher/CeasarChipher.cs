using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    class CeasarChipher : ICipher
    {
        public int Nyckel { get; set; }
            
        public CeasarChipher(int _nyckel)
        {
            Nyckel = _nyckel;
        }

        public string Encrypt(string input)
        {
            string output = "";
            foreach (char a in input) 
            {

                output += GetCipherChar(a, Nyckel);
                
            }
            return output;

        }

        public string Decrypt(string input)
        {
            string output = "";
            foreach (char a in input)
            {
                output += GetCipherChar(a, - Nyckel);
            }
            return output;
        }
        private char GetCipherChar (char c, int steps)
        {
            List<char> specialCharacters = new List<char>() { 'å', 'ä', 'ö' };

            if (!char.IsLetter(c) || specialCharacters.Contains(char.ToLower(c)))
            {
                return c;
            }
            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + steps) - d) % 26) + d);
        }
    }
}
