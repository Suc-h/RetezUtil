using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    /// <summary>
    /// Třída Pole
    /// </summary>
    public class Pole
    {

        /// <summary>
        /// Celek
        /// </summary>
        /// <param name="n"> pocet hodnot </param>
        /// <param name="dol"> dolní hranice generace </param>
        /// <param name="hor"> horní hranice generace </param>
        /// <returns>Vrací pole hodnot </returns>
        public static int[] Nacti(int n, int dol = 1, int hor = 100)
        {
            Random rn = new Random();
            int[] p = new int[n];
            for (int i = 0; i < p.Length; i++)
            {
                int x = rn.Next(dol, hor);
                p[i] = x;

            }
            return p;
        }


        
        
        /// <summary>
        /// Smaže čísla v řetězci
        /// </summary>
        /// <param name="s">Text z textboxu</param>
        /// <returns></returns>
        public static string Smaz(string s)
        {
            s = s.Trim();
            s= s.ToLower();

            
            StringBuilder novyRetezec = new StringBuilder();

            foreach (char znak in s)
            {
                
                if (char.IsDigit(znak))
                {
                   
                }
                else
                {
                    novyRetezec.Append(znak);
                }

            }
            s= novyRetezec.ToString();
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }
            return s;

        }
        
    }
}
