using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    class Rövarspråket : Cipher
    {
        public Rövarspråket(string _chiffer) : base(_chiffer)
        {
        }
        /// <summary>
        /// Encrypt utifrån input som givits. Lista med vokaler som används inom en for loop...
        /// för att set om dessa finns i input. Om så är fallet läggs de till i temp oförändrade. Annars...
        /// läggs 'o' och item (konsonanten) till i den tomma strängen temp.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string Encrypt(string input)
        {
            string temp = "";
            List<char> lista = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö', 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };

            foreach(char item in input)
            {
                if (!lista.Contains(item))
                {
                    temp = temp + item + "o" + item;
                }
                else
                {
                    temp = temp + item;
                }
            }
            return temp;
        }


    /// <summary>
    /// for loop som ser om vokaler från Lista finns i input. Om de inte görs tas bokstaven samt två bokstäver framför i bort.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public override string Decrypt(string input)
        {
            string temp = "";
            List<char> lista = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö', 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
            for (int i = 0; i < input.Length; i++)
            {
                if (lista.Contains(input[i]))
                {
                    temp += input[i];
                }
                else
                {
                    temp = temp + input[i];
                    input = input.Remove(i, 2);
                }
            }
            return temp;
        }
    }
}
