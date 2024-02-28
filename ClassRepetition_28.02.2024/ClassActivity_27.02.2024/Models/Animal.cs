using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassActivity_27._02._2024.Models
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Test();
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
