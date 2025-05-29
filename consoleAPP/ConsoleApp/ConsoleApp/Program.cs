using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string eleresiUt = "yacht_berlesek_2024.csv";
            List<Berles> berlesek = new List<Berles>();
            FileStream folyam = new FileStream(eleresiUt, FileMode.Open);
            StreamReader olvaso = new StreamReader(folyam);
            olvaso.ReadLine();
            while (!olvaso.EndOfStream)
            {
                string sor = olvaso.ReadLine();
                string[] berlesValtozok = sor.Split(',');

                Berles berles = new Berles();
                berles.Uid = int.Parse(berlesValtozok[0]);
                berles.YachtId = int.Parse(berlesValtozok[1]);
                berles.StartDate = DateTime.Parse(berlesValtozok[2]);
                berles.EndDate = DateTime.Parse(berlesValtozok[3]);
                berles.DailyPrice = int.Parse(berlesValtozok[4]);
                berles.Name = berlesValtozok[5];

                berlesek.Add(berles);
            }
        }

    }
}




