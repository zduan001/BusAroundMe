using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    /* Desing the data structures for a generic deck of cards. explain how your 
     * would subclass the data structures to implement the blacjack.
     */
    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public class Card
    {
        public Suit Suit;
        public int FaceValue;

        public Card(int value, Suit suit)
        {
            this.Suit = suit;
            this.FaceValue = value;
        }
    }

    public class Deck<T> where T : Card
    {
        public List<T> Cards;
        public int DealtIndex;

        public void Shuffle() { }
        public T Deal();
        public List<T> DealHands();
    }

    public class Hand<T> where T : Card
    {
        List<T> Cards;

        public int Sscore
        {
            get
            {
                //calculate the score.
                return 0;
            }
        }

        public void AddCard(T card)
        {
            Cards.Add(card);
        }

        public T remove(T card)
        {
            if (true)
            {
                Cards.Remove(card);
                return card;
            }
            else
            {
                return null;
            }
        }
    }

    #region black jack card

    public class BlackJackCard : Card
    {
        public BlackJackCard(Suit s, int Value)
            : base(Value, s)
        {
        }

        public bool IsAces;

        public override int Value
        {
            get
            {
                if (FaceValue >= 11 && FaceValue <= 13)
                {
                    return 1;
                }
                else
                {
                    return FaceValue;
                }
            }
        }
    }

    public class BlacJackHands<BlackJackCard> :Hand<BlackJackCard>
    {
        List<BlackJackCard> Cards;

        public BlacJackHands(List<BlackJackCard> cards)
        {
            Cards = cards;
        }

        public int[] PossibleScore
        {
            get
            {
                //Calcualte Score.
                return new int[] { 0 };
            }
        }

        public bool Isbusted
        {
            get
            {
                return true;
            }
        }
    }

    #endregion
}
