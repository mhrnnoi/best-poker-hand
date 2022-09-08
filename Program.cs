using System;
using System.Linq;
namespace best_poker_hand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME ");


            var rnks = new int[] { 3, 3, 4, 4, 4 };
            var suits = new char[] { '♠', '♠', '♠', 'a', '♠' };
            Console.WriteLine(BestHand(rnks, suits));

        }
        public static string BestHand(int[] ranks, char[] suits)
        {
            if (IsFlush(suits))
                return "Flush";

            else if (IsThreeOfKind(ranks))
                return "Three of Kind";

            else if (IsPair(ranks))
                return "Pair";
            else 
                return "high card : " + HighCard(ranks);
        }

    
        public static bool IsFlush(char[] suits)
        {
            var sameSuit = 1;
            for (int i = 0; i < suits.Length - 1; i++)
            {
                if (suits[i] == suits[i + 1])
                    sameSuit++;
            }


            if (sameSuit == 5)
                return true;
            return false;
        }


        public static bool IsPair(int[] ranks)
        {

            var sameRank = 1;

            bool x = false;

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                sameRank = 1;
                for (int j = i; j < ranks.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                        sameRank++;
                }
                x = (sameRank == 2) ? true : false;
                if (x)
                    return x;

            }
            return x;
        }



        public static bool IsThreeOfKind(int[] ranks)
        {
            var sameRank = 1;

            bool x = false;

            for (int i = 0; i < ranks.Length - 1; i++)
            {
                sameRank = 1;
                for (int j = i; j < ranks.Length - 1; j++)
                {
                    if (ranks[i] == ranks[j + 1])
                        sameRank++;
                }
                x = (sameRank == 3) ? true : false;
                if (x)
                    return x;

            }
            return x;
        }


        public static string HighCard(int[] ranks)
        {
            
            if (ranks.Contains(1))

                //cuz 1 is highest card
                return 1.ToString();

            return ranks.Max().ToString();

        }


    }
}
