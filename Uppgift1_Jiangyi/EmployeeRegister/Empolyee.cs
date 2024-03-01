using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_Jiang.EmployeeRegister
{
    internal class Empolyee:Object
    {
        //using properties: Automatic properties
        public string Name {  get; set; }
        public uint Salary {  get; set; }
        public EmployeeTypeEnum EmployeeType { get; set; }

        public Empolyee(string name, uint salary) {
            Name = name;
            Salary = salary;
        }
        public  Empolyee(string name, uint salary, EmployeeTypeEnum employeeType) { 
            Name = name;
            Salary= salary;
            EmployeeType = employeeType;  
        }


        public override string ToString() {
            return $"Name: {Name} , Salary: {Salary}";
        }
    }
}
