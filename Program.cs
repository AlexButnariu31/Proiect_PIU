using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incercare_tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 =new Calculator("NitroV", "Acer");
            string s1 = c1.Info();
            Console.WriteLine(s1);
            Console.WriteLine();

            Agenda a1 = new Agenda("NitroV", "Acer", "34hgd4", 700);
            string s2 = a1.Info_a();
            Console.WriteLine(s2);
            Console.WriteLine();

            Persoana p1 = new Persoana("Butnariu", "Alexandru");
            string s3 = p1.Info_p();
            Console.WriteLine(s3);
            Console.WriteLine();
        }
    }
}
