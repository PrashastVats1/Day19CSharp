using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReflectionExOne
{
    public class OurClass
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Our Class");
        }
        public void SecondMethod()
        {
            Console.WriteLine("Second Method");
        }
        private int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
    }
}
