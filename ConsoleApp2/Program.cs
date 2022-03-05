using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "bxsam yagis basladi";
            for (int i = 0; i < metin.Length; i++)
                

            {
                if (metin[i] == 'a')
                    Console.WriteLine("metinde a herifi var");
                else
                {
                    Console.WriteLine("metinde a herifi yoxdur");  
                }
                Console.ReadLine();

            }
        }
    }
}
