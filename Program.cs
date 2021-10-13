using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inser_Tri
{
    class MainClass
    {

        public static void Main(string[] args)
        {
          
            string[] students = { "henri", "Alexandre", "Olivier", "Léa", "Morgan", "Mathieu", "Bruno", "Laure", "Alix", "Louis" };

          
            AfficherTab(TriParSelection(students));



        }

        static void AfficherTab(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }

        static bool ComparaisonAscii(string a, string b)
        {
            bool res = false;
            int compt = 0;
            a = a.ToLower();
            b = b.ToLower();
            if (a == b) return res;

            while (a[compt] == b[compt])
            {
                compt++;
            }

            if (Convert.ToInt32(a[compt]) < Convert.ToInt32(b[compt]))
            {
                res = true;
            }

            return res;
        }

        static int Pos_min(string[] tab, int ind)
        {
          

            for (int i = ind; i < tab.Length; i++)
            {

                if (ComparaisonAscii(tab[i], tab[ind]))
                {

                    ind = i;
                }
            }
            return ind;
        }

        static string[] Echanger(string[] tab, int x, int y)
        {
           
            string temp = tab[x];
            tab[x] = tab[y];
            tab[y] = temp;
            return tab;
        }

        static string[] TriParSelection(string[] tab)
        {

            for (int i = 0; i < tab.Length; i++)
            {
                tab = Echanger(tab, i, Pos_min(tab, i));

            }

            return tab;
        }



    }
}
