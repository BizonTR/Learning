using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee Class Used. ");
            Id ="Id not assigned.";
        }

        public Employee(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public override string ToString()
        {
            return FullName;
        }
        public string Name { get; set; } //get varsa bu değişken farklı metodlar tarafından okunabilir, set varsa bu değişkene bir değer yazılabilir.
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public string Id { get; set; }
        public string Office { get; set; }

        //propfull tab tab
        private string _freeinfo;

        public string FreeInfo
        {
            get { return _freeinfo.ToUpper(); }
            set { _freeinfo = value; }
        }

        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 5500)
                {
                    value = 5500;
                }
                else
                {
                    value = value;
                }
                _salary= value;
            }
            
        }

        public string FullName { 
            get
            {
                return $"{Name} {LastName}";
            }
            }


    }
}
