using System;
using System.Linq;
namespace best_poker_hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME ");


            var rnks = new int[] { 4, 3, 2, 9, 5 };
            var suits = new char[] { '♠', '♠', '♠', '♠', '♠' };
            Console.WriteLine(BestHand(rnks, suits));

        }
        public static string BestHand(int[] ranks, char[] suits)
        {
            var sameSuit = 1;
            var sameRank = 1;

            for (int i = 0; i < suits.Length - 1; i++)
            {
                if (suits[i] == suits[i + 1])
                    sameSuit++;
            }


            if (sameSuit == 5)
                return "Flush";


            for (int i = 0; i < suits.Length - 1; i++)
            {
                if (ranks[i] == ranks[i + 1])
                    sameRank++;
            }

            switch (sameRank)
            {
                case 3:
                    return "Three of a Kind";

                case 2:
                    return "Pair";


                default:

                    if (ranks.Contains(1))

                        //cuz 1 is highest card
                        return 1.ToString();

                    return ranks.Max().ToString();

            }




        }
    }
}
