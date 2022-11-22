
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string hovno = "";
      /*Kostky hra1 = new Kostky();
      hra1.Locked = true;
      hra1.Size = 6;
      hra1.PocetKostek = 5;
      
      string hovno = "";

      hra1.HodnotyMoznostHodu = new int[+hra1.PocetKostek];
      
      for(int i = 0; i < hra1.PocetKostek; i++)
      {

          hra1.HodnotyMoznostHodu[i] += hra1.Roll();
          hovno += ("kostka" + hra1.HodnotyMoznostHodu[i] + " ");

      }

      hra1.Value();
      Console.WriteLine(hra1.ValueKostek);
      Console.WriteLine(hovno);

      hra1.RollAll();
      
      for(int i = 0; i < hra1.HodnotyMoznostHodu.Length; i++)
      {
        Console.WriteLine(hra1.HodnotyMoznostHodu[i]);
      }
      */
      
      Kostky Hrac1 = new Kostky();
      Hrac1.Size = 6;
      Hrac1.PocetKostek = 5;
      
      Hrac1.HodnotyMoznostHodu = new int[+Hrac1.PocetKostek];
      
      for(int i = 0; i < Hrac1.PocetKostek; i++)
      {

        Hrac1.HodnotyMoznostHodu[i] += Hrac1.Roll();
        hovno += ("kostka" + Hrac1.HodnotyMoznostHodu[i] + " ");

      }
      Console.WriteLine(hovno);

      Hrac1.RollAll();
      Console.WriteLine(Hrac1.HodnotyMoznostHodu);


      Kostky Hrac2 = new Kostky();
      Hrac2.Size = 6;
      Hrac2.PocetKostek = 5;
      
      
      
      
    }
    }
  
}