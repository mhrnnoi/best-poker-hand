using System;
using System.Linq;
namespace best_poker_hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME ");


            var rnks = new int[] {4, 3, 9, 1, 1};
            var suits = new char[]{'♠', '♥', '♣', '♦', '♦'};
            Console.WriteLine(BestHand(rnks, suits));

        }
        public static string BestHand(int[] ranks, char[] suits)
        {
            var sameSuit = 0;
            var sameRank = 0;

            for (int i = 0; i < suits.Length - 1; i++)
            {
                if (suits[i] == suits[i + 1])
                {
                    sameSuit++;
                }
            }
            if (sameSuit == 4)
            {
                return "Flush";
            }

            for (int i = 0; i < suits.Length - 1; i++)
            {
                if (ranks[i] == ranks[i + 1])
                {
                    sameRank++;
                }
            }
            if (sameRank >=2)
            {
                return "Three of a Kind";
            }
            if (sameRank == 1)
            {
                return "Pair";
            }
            if (ranks.Contains(1))
            {
                return 1.ToString();
            }
            return ranks.Max().ToString();



        }
    }
}
