using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    class Samlingsklass : ICipher, IEnumerable<Cipher>
    {
        public IEnumerator<Cipher> GetEnumerator()
        {
            return SamladLista.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return SamladLista.GetEnumerator();
        }
        /// <summary>
        /// Skapar listan SamladLista för att veta vilka chiffer som kommer användas.
        /// </summary>
        public List<Cipher> SamladLista = new List<Cipher>();

        public int Count { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Samlingsklass()
        {

        }

        /// <summary>
        /// De två metoderna Encrypt och Decrypt tar emot en string input och med en foreach loop går igenom alla valda chiffer i applikationen dvs SamladLista...
        /// och utnyttjar respektive klass Encrypt/Decrypt metod för input. Returnerar sedan input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string Encrypt(string input)
        {
            foreach(Cipher c in SamladLista)
            {
                input = c.Encrypt(input);
            }
            return input;

        }
        public string Decrypt(string input)
        {
            SamladLista.Reverse();
            foreach(Cipher c in SamladLista)
            {
                input = c.Decrypt(input);
            }
            SamladLista.Reverse();
            return input;
        }
        /// <summary>
        /// De två metoderna AddItems och RemoveItems lägger till / tar bort ett valt chiffer från listan av chiffer som kommer användas dvs SamladLista.
        /// </summary>
        /// <param name="cipher"></param>
        public void AddItems(Cipher cipher)
        {
            SamladLista.Add(cipher);
        }
        public void RemoveItems(Cipher cipher)
        {
            SamladLista.Remove(cipher);
        }
    }
}
