using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            byte b = (byte) i;

            var number = "526";
            int stringToInt = Convert.ToInt32(number);

            try
            {
                byte stringToByte = Convert.ToByte(number);
                Console.WriteLine(stringToByte);
            }
            catch (Exception)
            {
                Console.WriteLine("Ne radi. Nemože convertat string u byte");
            }

            try
            {
                string str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch (Exception)
            {
                Console.WriteLine("Ne radi");
            }

            Console.WriteLine(b);
            Console.WriteLine(stringToInt);
            Console.ReadKey();
        }
    }
}
