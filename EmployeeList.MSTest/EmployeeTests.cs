using Exercise1;

namespace EmployeeList.MSTest
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            //Arrange
            const int juniorSalary = 10000;
            const string name = "Kalle";
            var emp = new Employee(name, juniorSalary);
            var expected = SalaryLevel.Junior;

            //Act
            var actual = emp.SalaryLevel;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelSenior()
        {
            //Arrange
            const int seniorSalary = 30000;
            const string name = "Kalle";
            var emp = new Employee(name, seniorSalary);
            var expected = SalaryLevel.Senior;

            //Act
            var actual = emp.SalaryLevel;

            Assert.AreEqual(expected, actual);
        }

        //[DataTestMethod]
        //[DataRow(2)]
        //public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior2(uint salary)
        //{
        //    //Arrange
        //    const string name = "Kalle";
        //    var emp = new Employee(name, salary);
        //    var expected = SalaryLevel.Junior;

        //    //Act
        //    var actual = emp.SalaryLevel;

        //    Assert.AreEqual(expected, actual);
        //}
    }

}