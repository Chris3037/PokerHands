using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards testCards = new Cards("AS");
            string print = "5H 5C 6S 7S KD";
            Hand myHand = new Hand(print);

            Console.WriteLine(testCards.CardName);
            Console.ReadKey();
        }
    }
}
