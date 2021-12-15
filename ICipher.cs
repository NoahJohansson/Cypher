using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    interface ICipher
    {
        /// <summary>
        /// Lägger till metoderna Encrypt och Decrypt, AddItems och RemoveItems som alla klasser som ärver från ICipher måste deklarera.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        string Encrypt(string input);
        string Decrypt(string input);
        void AddItems(Cipher cipher);
        void RemoveItems(Cipher cipher);
        /// <summary>
        /// Anger egenskapen Count.
        /// </summary>
        int Count {get; set; }
    }
}
