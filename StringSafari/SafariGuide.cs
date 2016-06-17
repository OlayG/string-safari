using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSafari
{
    public class SafariGuide
    {
        /// <summary>
        /// Looks for a baby zebra in <paramref name="str"/>.
        /// <para>A baby zebra is "zebra", all lowercase.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has "zebra" in it, false otherwise</returns>
        public static bool HasBabyZebra(string str)
        {
            // TODO
            if (str.Contains("zebra"))
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Looks for an adult zebra in <paramref name="str"/>.
        /// <para>An adult zebra is "ZEBRA", all uppercase.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has "ZEBRA" in it, false otherwise</returns>
        public static bool HasAdultZebra(string str)
        {
            // TODO
            if (str.Contains("ZEBRA"))
            {
                return true;
            } else
            {       
                return false;
            }
        }

        /// <summary>
        /// Looks for a zebra in <paramref name="str"/>.
        /// <para>A zebra is the letters "ZEBRA", in any case combination (upper or lower)</para>
        /// <para>"Zebra", "zebra", "ZEBRA", and "ZeBrA" are all valid examples of zebras.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has a zebra in it, false otherwise</returns>
        public static bool HasZebra(string str)
        {
            // TODO
            if (str.ToLower().Contains("zebra"))
            {
                return true;
            } else
            {
                return false;
            }         
        }

        /// <summary>
        /// Looks for at least two zebras in <paramref name="str"/>.
        /// <para>A zebra is defined as it is for the <see cref="HasZebra(string)"/> method.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two zebras in it, false otherwise</returns>
        public static bool HasADazzle(string str)
        {
            // "lion zebra zebra"
            //  0123456789012345
            string newString = str.ToLower();
            int firstZebra = newString.IndexOf("zebra");
            int lastZebra = newString.LastIndexOf("zebra");

            if (firstZebra == lastZebra)
            {
                // only one zebra!
                return false;
            }
            else
            {
                // at least two zebras
                return true;
            }

        }

        /// <summary>
        /// Looks for at least two lions in <paramref name="str"/>.
        /// <para>A lion is the letters "LION", in any case combination (upper or lower)</para>
        /// <para>"Lion", "lion", "LION", and "LiOn" are all valid examples of lions.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two lions in it, false otherwise</returns>
        public static bool HasAPride(string str)
        {
            string lowerCaseStr = str.ToLower();
            int firstLion = lowerCaseStr.IndexOf("lion");
            int secondLion = lowerCaseStr.LastIndexOf("lion");

            if (firstLion == secondLion)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Looks for a pride of lions and only one zebra in <paramref name="str"/>.
        /// <para>If there are two or more zebras, this method should return false.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two lions in it and just one zebra, false otherwise</returns>
        public static bool ThereWillBeBlood(string str)
        {
            if (HasAPride(str) && (!HasADazzle(str) && HasZebra(str)))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        /// <summary>
        /// Looks for a lion and determines if the lion is far enough away for safety.
        /// <para>If there is no lion, this method returns true.</para>
        /// <para>If there is a lion at the start of the string, this method returns false.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if there is no lion at the start of the string</returns>
        public static bool SafeDistanceToLion(string str)
        {
            if ((str.ToLower()).StartsWith("lion"))
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Looks for at least two zebras and 2 lions in <paramref name="str"/>.
        /// <para>A zebra is defined as it is for the <see cref="HasZebra(string)"/> method.</para>
        /// <para>A lion is defined as it is for the <see cref="HasAPride(string)"/> method.</para>
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>true if the string has at least two zebras and lions in it, false otherwise</returns>
        public static bool NoahsArk(string str)
        {
            // TODO

            if ((HasBabyZebra(str) && HasAdultZebra(str)) && HasAPride(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int EvenChars(string str)
        {
            string str1 = str.Replace(" ", "");
            int strLength = str1.Length;
            int strChar = 0;
            int counter = 0;
        
            while (strChar < strLength)
            {
                if (strChar % 2 == 0)
                {
                    counter++;
                }
                strChar++;
            }

            return counter;

        }

    }
}
