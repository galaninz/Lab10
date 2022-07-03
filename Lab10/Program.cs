using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grad = Convert.ToDouble(Console.ReadLine());
            double minute = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());

            Angle angle = new Angle(grad, minute, second);

            double radian = angle.ToRadian();
            Console.WriteLine("Угол в радианах - {0}", radian);
            Console.WriteLine("{0} градусов {1} минут {2} секунд", grad, minute, second);
            Console.ReadKey();
        }
    }
}
