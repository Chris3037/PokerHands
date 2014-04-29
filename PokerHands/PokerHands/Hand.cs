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
        public List<string> hand { get; set; }

        public Hand(string handString)
        {
            this.cards = new List<Cards>();
            this.hand = new List<string>();
            //HandString is 5H 5C 6S 7S KD
            var handSplit = handString.Split(' ');
            for (int i = 0; i < handSplit.Length; i++)
            {
                this.hand.Add(handSplit[i].ToString());
                Cards myCards = new Cards(handSplit[i]);
            }

            bool hearts = false;
            bool diamonds = false;
            bool spades = false;
            bool clubs = false;

            Cards myCard = new Cards("AS");
            switch (myCard.CardSuit)
            {
                case "hearts": hearts = true; break;
                case "diamonds": diamonds = true; break;
                case "spades": spades = true; break;
                case "clubs": clubs = true; break;
            }

            bool two = false;
            bool three = false;
            bool four = false;
            bool five = false;
            bool six = false;
            bool seven = false;
            bool eight = false;
            bool nine = false;
            bool ten = false;
            bool eleven = false;
            bool twelve = false;
            bool thirteen = false;
            bool fourteen = false;

            switch (myCard.CardRank)
            {
                case "Two": two = true; break;
                case "Thre": three = true; break;
                case "Four": four = true; break;
                case "Five": five = true; break;
                case "Six": six = true; break;
                case "Seven": seven = true; break;
                case "Eight": eight = true; break;
                case "Nine": nine = true; break;
                case "Ten": ten = true; break;
                case "jack": eleven = true; break;
                case "queen": twelve = true; break;
                case "king": thirteen = true; break;
            }



            if (hand[0] == hand[1] && hand[0] == hand[2] && hand[0] == hand[3] && hand[0] == hand[4])
            {
                if (hand[0])
                {

                }
            }






            Console.WriteLine(myCard.CardName);




            Console.WriteLine();
            foreach (var item in hand)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
