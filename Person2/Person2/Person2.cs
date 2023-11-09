using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person2
{
    internal class Person2
    {
        private string name;
        private string familiq;
        private int age;
        private string grad;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Familiq
        {
            get { return familiq; }
            set { familiq = value; }
        }
        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }
        public void Introduce()
        {
            Console.WriteLine("I am {0} {1). I am {2}yrs old. I am from {3}", name, familiq, age, grad);
        }

    }

}