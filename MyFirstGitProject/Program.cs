using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstGitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string sor; 
            Console.WriteLine("Kacsa");
            StreamReader olvas = new StreamReader("auto.csv");
            List<Auto> autos = new List<Auto>(); 
            olvas.ReadLine();
            do
            {
                sor = olvas.ReadLine();
                string[] i = sor.Split(';');
                Auto a = new Auto(i[0], i[1], Convert.ToInt32(i[2]), Convert.ToInt32(i[3]), i[4], Convert.ToInt32(i[5]));
                autos.Add(a);


            } while (!olvas.EndOfStream);

            Console.WriteLine(autos[1]);
            olvas.Close();
            Console.ReadKey();

        }


    }
}
