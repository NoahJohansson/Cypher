using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    class OddAndEvenCipher : Cipher
    {
        public string chiffer { get; set; }

        public OddAndEvenCipher(string _chiffer) : base(_chiffer)
        {
        }
        /// <summary>
        /// En for loop används för att kolla om bokstaven i string input ligger på udda eller jämn indexposition.
        /// De som ligger på udda plats samlas i string temp och de på jämn i string temp2. Slutligen konkateneras dessa...
        /// för att bilda temp3 som returneras.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string Encrypt(string input)
        {
            string temp = "";
            string temp2 = "";
            char [] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if(i % 2 != 0)
                {
                    temp += arr[i];
                }
                else
                {
                    temp2 += arr[i];
                }
            }
            string temp3 = temp + temp2;
            return temp3;
        }
        /// <summary>
        /// input delas upp i två delar. Den ena kommer vara ojämn...
        /// och den andra jämn. Dessa for loopas och görs om. 
        /// Om det är ett udda tal så läggs sista bokstaven till.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public override string Decrypt(string input)
        {
            string temp = "";
            int even = input.Length / 2;
            for (int i = 0; i < even; i++)
            {
                temp = temp + input[i + even] + input[i];
            }
            if(input.Length % 2 != 0)
            {
                temp = temp + input[input.Length - 1];
            }
            return temp;
        }
    }
}
