using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackGame
{

    public enum GameResult { Win = 1, Lose = -1, Draw = 0, Pending = 2};

    //lap id, fajta, érték 
    public class Card
    {
        public string ID { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string id, string suit, int value)
        {
            ID = id;
            Suit = suit;
            Value = value;
        }
    }

    //maga a pakli
    public class Deck : Stack<Card>
    {
        public Deck(IEnumerable<Card> collection) : base(collection) { }
        public Deck() : base(52) { }


        //indexer
        public Card this[int index]
        {
            get
            {
                Card item;

                if (index >= 0 && index <= this.Count - 1)
                {
                    item = this.ToArray()[index];
                }
                else
                {
                    item = null;
                }

                return item;
            }
        }

        //deck érték
        public double Value
        {
            get
            {
                return BlackJackRules.HandValue(this);
            }
        }
    }

    //játékos és az osztó
    public class Member
    {
        public Deck Hand;
        public Member()
        {
            Hand = new Deck();
        }
    }

    public static class BlackJackRules
    {
        public static string[] ids = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "K", "Q" };

        public static string[] suits = { "C", "D", "H", "S" };

        public static Deck NewDeck
        {
            get
            {
                Deck d = new Deck();
                int value;
                foreach (string suit in suits)
                {
                    foreach(string id in ids)
                    {
                        value = Int32.TryParse(id, out value) ? value : id == "A" ? 1 : 10;
                        d.Push(new Card(id, suit, value));
                    }
                }
                return d;
            }
        }
        //új megkavart deck
        public static Deck ShuffleDeck
        {
            get
            {
                return new Deck(NewDeck.OrderBy(Card => System.Guid.NewGuid()).ToArray());
            }
        }

        //kéz értéke
        public static double HandValue(Deck deck)
        {
            //ász értéke 1
            int val1 = deck.Sum(c => c.Value);

            //ász értéke 11
            double aces = deck.Count(c => c.Suit == "A");
            double val2 = aces > 0 ? val1 + (10 * aces) : val1;

            return new double[] { val1, val2 }
                .Select(handVal => new
                {
                    handVal,
                    weight = Math.Abs(handVal - 21) + (handVal > 21 ? 100 : 0)
                })
                .OrderBy(n => n.weight)
                .First().handVal;
        }


        public static bool CanDealerHit(Deck deck, int standLimit)
        {
            return deck.Value < standLimit;
        }

        public static bool CanPlayerHit(Deck deck)
        {
            return deck.Value < 21;
        }

        public static GameResult GetResult(Member player, Member dealer)
        {
            GameResult res = GameResult.Win;

            double playerValue = HandValue(player.Hand);
            double dealerValue = HandValue(dealer.Hand);

            //a játékos akkor lehet győztes ha:
            if (playerValue <= 21)
            {
                if (playerValue != dealerValue)
                {
                    double closetValue = new double[] { playerValue, dealerValue }
                        .Select(handVal => new
                        {
                            handVal,
                            weight = Math.Abs(handVal - 21) + (handVal > 21
                        ? 100 : 0)
                        })
                            .OrderBy(n => n.weight)
                            .First().handVal;
                    res = playerValue == closetValue ? GameResult.Win : GameResult.Lose;
                }
                else
                {
                    res = GameResult.Draw;
                }
            }
            else
            {
                res = GameResult.Lose;
            }

            return res;
        }
    }

    public class BlackJack
    {
        public Member Dealer = new Member();
        public Member Player = new Member();
        public GameResult Result { get; set; }

        public Deck MainDeck;

        public int StandLimit { get; set; }

        public BlackJack(int dealerStandLimit)
        {
            Result = GameResult.Pending;

            StandLimit = dealerStandLimit;

            //új, kevert pakli behozása
            MainDeck = BlackJackRules.ShuffleDeck;

            //osztó és a játékos kezének ürítése
            Dealer.Hand.Clear();
            Player.Hand.Clear();

            for (int i = 0; i < 3; i++)
            {
                Dealer.Hand.Push(MainDeck.Pop());
                Player.Hand.Push(MainDeck.Pop());
            }
        }

        public void Hit()
        {
            if(BlackJackRules.CanPlayerHit(Player.Hand) && Result == GameResult.Pending)
            {
                Player.Hand.Push(MainDeck.Pop());
            }
        }


        public void Stand()
        {
            if (Result == GameResult.Pending)
            {
                
                while (BlackJackRules.CanDealerHit(Dealer.Hand, StandLimit))
                {
                    Dealer.Hand.Push(MainDeck.Pop());
                }

                Result = BlackJackRules.GetResult(Player, Dealer);
            }
        }
    }

    public class Program
    {
        public static void ShowStats(BlackJack bj)
        {
            Console.WriteLine("Dealer");
            foreach (Card c in bj.Dealer.Hand)
            {
                Console.WriteLine(string.Format("{0} {1}", c.ID, c.Suit));
            }

            Console.WriteLine(bj.Dealer.Hand.Value);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Player");
            foreach (Card c in bj.Player.Hand)
            {
                Console.WriteLine(string.Format("{0} {1}", c.ID, c.Suit));
            }

            Console.WriteLine(bj.Player.Hand.Value);

            Console.WriteLine(Environment.NewLine);
        }

        public static void Main()
        {
            string input = "";

            BlackJack bj = new BlackJack(17);
            ShowStats(bj);
            while (bj.Result == GameResult.Pending)
            {
                input = Console.ReadLine();

                if(input.ToLower() == "h")
                {
                    bj.Hit();
                    ShowStats(bj);
                }
                else
                {
                    bj.Stand();
                    ShowStats(bj);
                }
            }
            Console.WriteLine(bj.Result);
            Console.ReadLine();
        }
    }
}
