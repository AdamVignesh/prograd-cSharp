
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace PokerCombination
{
    public class PokerGame
    {
        static Dictionary<string, int> suiteDict;
        static Dictionary<string, int> rankDict;
        static Dictionary<string, int> sequenceDict; 
        public static Boolean RoyalFlush()
        {
            List<string> royalCheck = new List<string>() {"10","A","J","Q","K"};   
            foreach(KeyValuePair<string,int> rank in rankDict)
            {
                
                if (!(royalCheck.Contains(rank.Key)))
                {
                                    //Method to check for royal flush
                    return false;
                }
                
            }
            
            return true;
        }
        public static Boolean StraightFlush(string[] inputCards)
        {
            for(int cardIterator=0; cardIterator<inputCards.Length-1; cardIterator++)
            {
                string cardRank1 = inputCards[cardIterator].Substring(0, inputCards[cardIterator].Length - 1);      //Checking straight flush and straight too
                string cardRank2 = inputCards[cardIterator+1].Substring(0, inputCards[cardIterator+1].Length - 1);
                if (!(sequenceDict[cardRank1] == sequenceDict[cardRank2]+1))
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean straight(string[] inputCards)
        {
            return StraightFlush(inputCards);           // just calling straight flush as it is elseif ladder so this works
        }

        public static string handlePoker(string[] inputCards)
        {
            rankDict = new Dictionary<string, int>();
            suiteDict = new Dictionary<string, int>();
            sequenceDict = new Dictionary<string, int>();
            sequenceDict.Add("A", 1);
            sequenceDict.Add("1", 2);
            sequenceDict.Add("2", 3);
            sequenceDict.Add("3", 4);
            sequenceDict.Add("4", 5);
            sequenceDict.Add("5", 6);
            sequenceDict.Add("6", 7);
            sequenceDict.Add("7", 8);
            sequenceDict.Add("8", 9);                               // dictionary for checking sequence
            sequenceDict.Add("9", 10);
            sequenceDict.Add("10",11);
            sequenceDict.Add("J", 12);
            sequenceDict.Add("Q", 13);
            sequenceDict.Add("K", 14);

            foreach (var card in inputCards)
            {
                string cardKey = card.Substring(card.Length - 1);
                                                                                    
                if (suiteDict.ContainsKey(cardKey))                       // for loop for inserting the suite values to the dictionary
                {
                    suiteDict[cardKey]++;

                }
                else
                {
                    suiteDict.Add(cardKey, 1);
                }
            }
            foreach (var card in inputCards)
            {

                string cardRank = card.Substring(0, card.Length - 1);
                if (rankDict.ContainsKey(cardRank))                        // for loop for inserting the rank values to the dictionary
                {
                    rankDict[cardRank]++;

                }
                else
                {
                    rankDict.Add(cardRank, 1);
                }
            }
       
            int maxOccurrenceOfASuite = 0;          
            int maxOccurrenceOfARank = 0;
            int pairCount = 0;

            foreach (KeyValuePair<string, int> pair in suiteDict)
            {
                if (pair.Value > maxOccurrenceOfASuite)
                {                                                         // getting the max occurrence of a suite value
                    maxOccurrenceOfASuite = pair.Value;
                }
            }
            foreach (KeyValuePair<string, int> pair in rankDict)
            {
                if (pair.Value > maxOccurrenceOfARank)                    // getting the max occurrence of a rank value
                {
                    maxOccurrenceOfARank = pair.Value;
                }
            }
            foreach(KeyValuePair<string, int> pair in rankDict)
            {
                if(pair.Value==2)                                         // checking the number of pairs of ranks appeared
                {
                    pairCount++;
                }
            }

            if (maxOccurrenceOfASuite == 5)
            {
                if (RoyalFlush())
                {
                    return "It is a Royal Flush";
                }
                else if (StraightFlush(inputCards))
                {
                    return "It is a Straight Flush";
                }
                else
                {
                    return "It is Flush";
                }
            }
            else if(maxOccurrenceOfARank == 4)
            {
                return "It is Four of a Kind";
            }
            else if (maxOccurrenceOfARank == 3)
            {
                if(rankDict.ContainsValue(2))
                {
                    return "It is a Full House";
                }
                else
                {
                   return "It is Three of a Kind";
                }
            }
            else if(pairCount == 2)
            {
               return "It is a Two Pair";
            }
            else if(pairCount == 1)
            {
                return ("It is a Pair");
            }
            else if(straight(inputCards))
            {
                return ("It is straight");
            }
            else
            {
                return("It is High Card");
            }
                
        }

        public static void Main(string[] args)
        {
            
            string[] inputCards = new string[5];
            for (int inputIterator = 0; inputIterator < inputCards.Length; inputIterator++)
            {
                inputCards[inputIterator] = Console.ReadLine();
            }
            Console.WriteLine(handlePoker(inputCards));
            
        }
    }
}