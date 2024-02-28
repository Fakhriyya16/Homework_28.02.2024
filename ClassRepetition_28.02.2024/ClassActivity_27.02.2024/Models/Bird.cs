using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity_27._02._2024.Models
{
    internal class Bird : Animal
    {
        public string Color { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird Sound"); ;
        }
        public override void Test()
        {
            Console.WriteLine("tested"); ;
        }
    }
}
