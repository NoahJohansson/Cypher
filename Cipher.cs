using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    abstract class Cipher
    {
        /// <summary>
        /// Anger att de abstrakta metoderna Encrypt och Decrypt ska finnas.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public abstract string Encrypt(string input);

        public abstract string Decrypt(string input);
        /// <summary>
        /// Konstruktor för att skapa ett namn.
        /// </summary>
        public string Name { get; set;}

        public Cipher(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Override ToString-metoden för att utskrift inte ska bli i stil med <Cypher>.ReversalCipher utan ska bli namnet på valt chiffer.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }



    }
}
