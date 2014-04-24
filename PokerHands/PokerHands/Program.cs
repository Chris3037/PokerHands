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
            var testCards = new Cards("AS");
            var print = "5H 5C 6S 7S KD";
            var myHand = new Hand(print);

            Console.WriteLine(testCards.CardName);
            Console.ReadKey();
        }
    }
}
