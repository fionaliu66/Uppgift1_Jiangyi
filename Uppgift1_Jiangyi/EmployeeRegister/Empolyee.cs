using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_Jiang.EmployeeRegister
{
    internal class Empolyee
    {
        //using properties: Automatic properties
        public string Name {  get; set; }
        public int Salary {  get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

     
        public  Empolyee(string name, int salary, EmployeeTypeEnum employeeType) { 
            Name = name;
            Salary= salary;
            EmployeeType = employeeType;  
        }


        public override string ToString() {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}
