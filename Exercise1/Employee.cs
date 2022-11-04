//class employee
//namn och lön

namespace Exercise1
{
    public class Employee
    {
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
         
        public string Name { get; }
        public uint Salary { get; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;
        //{
        //    get{
        //        if(Salary < 25000)
        //        {
        //            return SalaryLevel.Junior;
        //        }
        //        else
        //        {
        //            return SalaryLevel.Senior;
        //        }
        //    }
        
        //}

        //Constructor
        public Employee(string name, uint salary)
        {
            //Validate?
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary} SalaryLevel: {SalaryLevel}";
        }

    }
}