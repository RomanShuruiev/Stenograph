using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Stenograph
{
    class Steno
    {
        public string Original;
        int XCoord;
        int YCoord;
        //int[,] Coord;
        bool Rus;
        bool Eng;
        int i, j;
        Dictionary<string, int> alphavite = new Dictionary<string, int>();


        public Steno(string original, bool Rus, bool Eng, int i, int j)
        {

            this.Original = original;
            this.Rus = Rus;
            this.Eng = Eng;
            this.i = i;
            this.j = j;

            Initialize(Rus, Eng);
           
        }

        public void Initialize(bool Rus, bool Eng)
        {
            if (Eng == true)
            {

                alphavite.Add("a", 0);
                alphavite.Add("b", 1);
                alphavite.Add("c", 2);
                alphavite.Add("d", 3);
                alphavite.Add("e", 4);
                alphavite.Add("f", 5);
                alphavite.Add("g", 6);
                alphavite.Add("h", 7);
                alphavite.Add("i", 8);
                alphavite.Add("j", 9);
                alphavite.Add("k", 10);
                alphavite.Add("l", 11);
                alphavite.Add("m", 12);
                alphavite.Add("n", 13);
                alphavite.Add("o", 14);
                alphavite.Add("p", 15);
                alphavite.Add("q", 16);
                alphavite.Add("r", 17);
                alphavite.Add("s", 18);
                alphavite.Add("t", 19);
                alphavite.Add("u", 20);
                alphavite.Add("v", 21);
                alphavite.Add("w", 22);
                alphavite.Add("x", 23);
                alphavite.Add("y", 24);
                alphavite.Add("z", 25);
                alphavite.Add(".", 26);
                alphavite.Add(",", 27);
                alphavite.Add("!", 28);
                alphavite.Add("?", 29);
                alphavite.Add(":", 30);
                alphavite.Add(";", 31);
                alphavite.Add("-", 32);
             
                
            }

            if (Rus == true)
            {

                alphavite.Add("а", 0);
                alphavite.Add("б", 1);
                alphavite.Add("в", 2);
                alphavite.Add("г", 3);
                alphavite.Add("д", 4);
                alphavite.Add("е", 5);
                alphavite.Add("ё", 6);
                alphavite.Add("ж", 7);
                alphavite.Add("з", 8);
                alphavite.Add("и", 9);
                alphavite.Add("й", 10);
                alphavite.Add("к", 11);
                alphavite.Add("л", 12);
                alphavite.Add("м", 13);
                alphavite.Add("н", 14);
                alphavite.Add("о", 15);
                alphavite.Add("п", 16);
                alphavite.Add("р", 17);
                alphavite.Add("с", 18);
                alphavite.Add("т", 19);
                alphavite.Add("у", 20);
                alphavite.Add("ф", 21);
                alphavite.Add("х", 22);
                alphavite.Add("ц", 23);
                alphavite.Add("ч", 24);
                alphavite.Add("ш", 25);
                alphavite.Add("щ", 26);
                alphavite.Add("ъ", 27);
                alphavite.Add("ы", 28);
                alphavite.Add("ь", 29);
                alphavite.Add("э", 30);
                alphavite.Add("ю", 31);
                alphavite.Add("я", 32);
                alphavite.Add(".", 33);
                alphavite.Add(",", 34);
                alphavite.Add("!", 35);
                alphavite.Add("?", 36);
                alphavite.Add(":", 37);
                alphavite.Add(";", 38);
                alphavite.Add("-", 39);
        }
        }
        public int XCoordinate()
        {
           

                return XCoord; 
                
            }
           
        

        public int YCoordinate()
        {
           

                return YCoord; 
                
            }
           
        }
       
}

