using System.Linq;

namespace TheTDDMob
{
    public class Task2
    {
        /// <summary>
        /// Given a string input, return the most common alpha-numeric character.
        /// If there is a tie, it should return the character with the first appearance in the string
        /// 
        /// ababbbbbbcc
        /// 
        /// </summary>
        public static char mostCommonCharacter(string input)
        {
            return input.GroupBy(y => y).OrderByDescending(x => x.Count()).First().Key;
        }

    }
}