using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_23
{
    internal class Car
    {
        public string Model;
        public string Brand;

        public void ShowInfo()
        {
            Console.WriteLine(Model + " - " + Brand);
        }
    }
}
