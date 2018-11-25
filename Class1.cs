using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10
{
    class Student
    {
        private string name;

        public string Name { get => Name; set => Name = value; }

        public Student(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }



    }
}
