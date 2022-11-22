
using System.Drawing;
using System.Runtime.CompilerServices;

namespace MyApplication
{
    class Kostka
    {
        public int Value;
        public int Size;
        public bool Locked;

        public int Roll()
        {
            Value = Random.Shared.Next(1, Size+1);
            return Value;
        }
    }

    class Kostky: Kostka
    {
        public int PocetKostek;
        public int Total;
        public string State;
        public int[] HodnotyMoznostHodu;
        public int ValueKostek;

        public int  []RollAll()
        {
            
            for(int i = 0; i < PocetKostek; i++)
            {
                SetLock();
                if (Locked)
                {
                    HodnotyMoznostHodu[i] += Roll() - HodnotyMoznostHodu[i];
                }
                else
                {
                }

                State += (HodnotyMoznostHodu[i] + " zamceny, ");
                Console.WriteLine(State);

            }
            return HodnotyMoznostHodu;
        }

        public bool SetLock()
        {
            string zmena = Console.ReadLine();
            if (zmena == "y")
            {
                Locked = false;
            }
            
            else
            {
                Locked = true;
            }

            return Locked;
        }

        public int Value()
        {
            Dictionary<Int32,Int32> bucket = new Dictionary<Int32,Int32>();
            Int32 maxInt = Int32.MinValue;
            Int32 maxCount = 0;
            Int32 count;

            foreach (var i in HodnotyMoznostHodu)
            {
                if (bucket.TryGetValue(i, out count))
                {
                    count++;
                    bucket[i] = count;
                }
                else
                {
                    count = 1;
                    bucket.Add(i,count);
                }

                if (count >= maxCount)
                {
                    maxInt = i;
                    maxCount = count;
                }

            }

            ValueKostek = maxCount;
            return ValueKostek;

        }
        }
    

    class Game
    {
        public string WinnerSlogan;
        public int hrac1_pocet_vyher;
        public int hrac2_pocet_vyher;
        


        public string Vyhodnoceni(int cislo1, int cislo2)
        {
            
            if (hrac1_pocet_vyher == 2)
            {
                WinnerSlogan = "Hráč 1 vyhrál celou hru. Gratuluji";
            }
            
            if (hrac2_pocet_vyher == 2)
            {
                WinnerSlogan = "Hráč 2 vyhrál celou hru. Gratuluji";
            }

            else if (cislo1 > cislo2)
            {
                WinnerSlogan = "Hráč 1 vyhrál tohle kolo";
                hrac1_pocet_vyher++;
            }

            else if (cislo1 < cislo2)
            {
                WinnerSlogan = "Hráč 2 vyhrál tohle kolo";
                hrac2_pocet_vyher++;
            }

            cislo1 = 0;
            cislo2 = 0;
            return WinnerSlogan;
        }
    }

}