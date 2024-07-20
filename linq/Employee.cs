using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace linq
{
    internal class Employee
    {

 
        
        

        
            public string Name { get; set; }
            public int Salary { get; set; }
        public string dep {  get; set; }


            public Employee(string name, int salary)
            {
                Name = name;
                Salary = salary;
            }
        public Employee(string name,string dep) { 

            this.Name = name;
            this.dep= dep;
        }   
        




    }
}
