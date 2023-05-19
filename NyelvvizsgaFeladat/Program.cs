namespace NyelvvizsgaFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vizsgak> lista = new List<Vizsgak>();

            StreamReader str = new StreamReader("sikeres.csv");
            StreamReader str2 = new StreamReader("sikertelen.csv");
            str.ReadLine();
            while (!str.EndOfStream)
            {
                lista.Add(new Vizsgak(str.ReadLine(),true));
            }
            str.Close();
            str2.ReadLine();
            while (!str2.EndOfStream)
            {
                lista.Add(new Vizsgak(str2.ReadLine()));
                
            }
            str2.Close();

            //2. feldata
            Console.WriteLine("2. feladat:");
            var listaRendezett = lista.OrderByDescending(x => x.Osszes).TakeWhile((x,i) => i != 3).ToList();
            listaRendezett.ForEach(x => Console.WriteLine(x.Nyelv));

            //3. feladat
            Console.WriteLine("3. feladat:");
            Console.WriteLine("Adjon meg egy évszámot: ");
            string evszam = Console.ReadLine();

            //4. feladat
            long osszeg = 0;
            var sikertelenLista = lista.Where(x => x.SikeresVagyNem == 'n');
            
            foreach (var item in sikertelenLista)
            {
                osszeg += item.Osszes;
            }
            var max = lista.MaxBy(x => (x.Osszes / osszeg) * 100);

            //5. feladat
            Console.WriteLine("5. feladat:");
            int szam = Convert.ToInt32(evszam)- 2008;
            List<string> nullaVizsgazo = new List<string>();
            StreamReader str3 = new StreamReader("sikeres.csv");
            StreamReader str4 = new StreamReader("sikertelen.csv");
            str3.ReadLine();
            while (!str3.EndOfStream)
            {
                string[] tomb = str3.ReadLine().Split(";");
                if (tomb[szam] == "0")
                {
                    nullaVizsgazo.Add(tomb[0]);
                }
            }
            str3.Close();
            str4.ReadLine();
            while (!str4.EndOfStream)
            {
                string[] tomb = str4.ReadLine().Split(";");
                if (tomb[szam] == "0")
                {
                    nullaVizsgazo.Add(tomb[0]);
                }

            }
            str4.Close();
            if (nullaVizsgazo.Count == 0)
            {
                Console.WriteLine("Minden nyelvből volt vizsgázó");
            }
            else 
            {
                nullaVizsgazo.ForEach(x => Console.WriteLine(x));
                
            }

            //6. feladat
            File.WriteAllLines("osszesites.csv", lista.Select(x => $"{x.Nyelv};{x.Osszes};{(x.Osszes / osszeg) * 100}"));



        }
    }
}