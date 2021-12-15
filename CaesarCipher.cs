using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    /// <summary>
    /// 
    /// </summary>
    class CaesarCipher : Cipher
    {
        public int Nyckel { get; set; }
            
        public CaesarCipher(int _nyckel, string name) : base(name)
        {
            Nyckel = _nyckel;
        }
        
        /// <summary>
        /// Tom sträng där varje char från input ändras med 'Nyckel' antal steg efter i alfabetet. Nyckel visar antal steg.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string Encrypt(string input)
        {
            string output = "";
            foreach (char a in input) 
            {

                output += GetCipherChar(a, Nyckel);
                
            }
            return output;

        }
        /// <summary>
        /// Decrypt sker på samma sätt som Encrypt. Skillnad är att 26 - läggs till innan nyckel för det är 26 bokstäver i alfabetet.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string Decrypt(string input)
        {
            string output = "";
            foreach (char a in input)
            {
                output += GetCipherChar(a, 26 - Nyckel);
            }
            return output;
        }
        private char GetCipherChar (char c, int steps)
        {
            List<char> specialCharacters = new List<char>() { 'å', 'ä', 'ö' };

            if (!char.IsLetter(c) && specialCharacters.Contains(char.ToLower(c)))
            {
                return c;
            }
            char d = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + steps) - d) % 26) + d);
        }
    }
}
