using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Data_Type_Char_and_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int chMin = Char.MinValue;
            int chMax = char.MaxValue;
            int MyChar = 'S';
            char MyCharAsCh = 'S';
          
            Console.WriteLine(Convert.ToChar(83));
            Console.WriteLine(Convert.ToChar(81));
            Console.WriteLine("chMin={0} , chMax={1} , Mychar={2},Char As int={3}" , chMin , chMax , MyChar,MyCharAsCh);
            string myString = "Hello ";
            Console.WriteLine(myString);

            bool Mybool = true;
            bool Mybool2 = false;
            Console.WriteLine(Mybool);
            Console.WriteLine(Mybool2);
                             





            Console.ReadKey();
        }
    }
}
