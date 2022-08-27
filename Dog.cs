using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public class Dog : Animals
    {
        public void Bark()
        {
            Console.WriteLine($"WOOOF");
        }
    }
}
