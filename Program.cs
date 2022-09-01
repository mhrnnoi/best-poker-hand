using System;
using System.Linq;
namespace best_poker_hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME ");


            var rnks = new int[] { 4, 3, 8, 9, 3 };
            var suits = new char[] { '♠', '♠', '♠', 'a', '♠' };
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
                for (int j = i; j < suits.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                    sameRank++;
                }

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
