using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IPayRoll
    {
        void AddEmployee(Employee employee);
        void AddEmployee(string name, uint salary);
        List<Employee> GetEmployees();
    }
}
