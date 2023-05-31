using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kemia> lista=new List<Kemia>();
            StreamReader sr = new StreamReader("felfedezesek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine();
                var mezok = sor.Split(';');
                lista.Add(new Kemia(Convert.ToInt32( mezok[0]) , mezok[1] , mezok[2], mezok[3], mezok[4])) ;
            }
            sr.Close();



            //3.feladat
            int elemSzam = lista.Count;

            Console.WriteLine($"3. feladat: Elemek száma: {elemSzam}");

            //4.feladat
            foreach (var item in lista)
            {
                if (lista.mezok[0])
                {

                }
            }

            //5.feladat
            Console.WriteLine("5. feladat: Kérek egy vegyjelet!");
            Console.Read();
            string bekertVegyjel;
            do
            {
                Console.WriteLine("5. feladat: Kérek egy vegyjelet!");
                bekertVegyjel = Console.ReadLine();
            } while (true);

            //6.feladat
               
            foreach (var item in lista)
            {
                if (Kemia.mezok[2]=bekertVegyjel)
                {
                    Console.WriteLine("6. feladat: Keresés");
                    Console.WriteLine($"\tAz elem vegyjele: {mezok[2]}");
                    Console.WriteLine($"\tAz elem neve: {mezok[1]}");
                    Console.WriteLine($"\tRendszáma: {mezok[3]}");
                    Console.WriteLine($"\tFelfedezés éve: {mezok[0]}");
                    Console.WriteLine($"\tFelfedező: {mezok[4]}");
                }
                else
                {
                    Console.WriteLine("6. feladat: Keresés");
                    Console.WriteLine("\tNincs ilyen elem az adatforrásban!");
                }
            }

            //7.feladat
            Console.WriteLine($"7. feladat: {} év volt a leghosszabb időszak két elem felfedezése között");

            //8.feladat
            Console.WriteLine("8. feladat: Statisztika");
            
            
        }
    }
}
