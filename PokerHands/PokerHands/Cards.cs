using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Cards
    {
        public List<Cards> cards { get; set; }
        public string Suit { get; set; }
        public int Rank { get; set; }
        public string CardName { get; set; }
        public string CardRank { get; set; }
        public string CardSuit { get; set; }

        //2H AD KC 10C
        public Cards(string cardString)
        {
            string Suit = cardString.Last().ToString();

            string tempRank = cardString.Substring(0, cardString.Length - 1);

            switch (tempRank.ToUpper())
            {
                case "2": this.Rank = 2; this.CardRank = "Two"; break;
                case "3": this.Rank = 3; this.CardRank = "Three"; break;
                case "4": this.Rank = 4; this.CardRank = "Four"; break;
                case "5": this.Rank = 5; this.CardRank = "Five"; break;
                case "6": this.Rank = 6; this.CardRank = "Six"; break;
                case "7": this.Rank = 7; this.CardRank = "Seven"; break;
                case "8": this.Rank = 8; this.CardRank = "Eigth"; break;
                case "9": this.Rank = 9; this.CardRank = "Nine"; break;
                case "10": this.Rank = 10; this.CardRank = "Ten"; break;
                case "J": this.Rank = 11; this.CardRank = "Jack"; break;
                case "Q": this.Rank = 12; this.CardRank = "Queen"; break;
                case "K": this.Rank = 13; this.CardRank = "King"; break;
                case "A": this.Rank = 14; this.CardRank = "Ace"; break;
            }

            switch (Suit.ToUpper())
            {
                case "H": this.CardSuit = "Hearts"; break;
                case "D": this.CardSuit = "Diamonds"; break;
                case "S": this.CardSuit = "Spades"; break;
                case "C": this.CardSuit = "Clubs"; break;
            }

            CardName = CardRank + " Of " + CardSuit;
            Console.WriteLine(CardName);
        }
    }
}
