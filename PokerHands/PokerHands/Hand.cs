using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Hand
    {
        public List<Cards> cards { get; set; }

        public Hand(string handString)
        {
            this.cards = new List<Cards>();
            //HandString is 5H 5C 6S 7S KD
            var handSplit = handString.Split(' ');
            for (int i = 0; i < handSplit.Length; i++)
            {
                cards.Add(new Cards(handSplit[i]));
            }
        }
    }
}
