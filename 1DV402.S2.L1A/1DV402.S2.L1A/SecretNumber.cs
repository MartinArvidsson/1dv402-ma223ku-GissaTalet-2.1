using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        int _count; //Variabel för hur många chanser man har
        int _number; // slumpgenereade numret
        public const int MaxNumberOffGuesses = 7; //Hur många gissningar man ska få.
        public SecretNumber() // Här Startas programmet och initialize
        {
            Initialize();
        }
        public void Initialize() // sätter count till 0 , anger också det slumpade talets värde
        {
            _count = 0;
            Random random = new Random();
            _number = random.Next(1, 101);
        }
        public bool MakeGuess(int number) // Här utförs vad som händer när användaren matar in olika värden.
        {
            if (_count >= MaxNumberOffGuesses) // om du gissar efter att gissningarna är slut, körs ett undantag
            {
                throw new ArgumentOutOfRangeException();
            }
            _count++;
            if (number == _number) // Om svaret är korrekt presenteras det med hur många försök det tog
            {
                Console.WriteLine("Korrekt! efter {0} försök fick du fram talet {1}", _count, _number);
            }
            if (_count == MaxNumberOffGuesses) // vad som visas när du har slut på gissningar
            {
                Console.WriteLine("Du har slut på gissningar, Svaret var {0}", _number);
            }
            if (number < 1 || number > 100) // om du gissar lägre eller högre än vad som är max/min körs ett undantag.
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number > _number) // om du gissar för högt visas kod som säger detta + hur många försök som är kvar.
            {
                Console.WriteLine("{0} är ett för stort tal, gissa lägre.", number, (MaxNumberOffGuesses - _count));
                return false;
            }
            if (number < _number) // om du gissar för lågt visas det + hur många försök som återstår.
            {
                Console.WriteLine("{0} är ett för litet tal, gissa högre.", number, (MaxNumberOffGuesses - _count));;
                return false;
            }

        }
    }
}
