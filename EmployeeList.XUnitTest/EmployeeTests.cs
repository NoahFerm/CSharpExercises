using Exercise1;
using Xunit;

namespace EmployeeList.XUnitTest
{
    public class EmployeeTests
    {
        [Fact]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            //Arrange
            const int juniorSalary = 10000;
            const string name = "Kalle";
            var emp = new Employee(name, juniorSalary);
            var expected = SalaryLevel.Junior;

            //Act
            var actual = emp.SalaryLevel;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelSenior()
        {
            //Arrange
            const int seniorSalary = 10000;
            const string name = "Kalle";
            var emp = new Employee(name, seniorSalary);
            var expected = SalaryLevel.Senior;

            //Act
            var actual = emp.SalaryLevel;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("hello", 24999)]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelSenior2(string name2, uint salary)
        {
            var emp = new Employee(name2, salary);
            var expected = SalaryLevel.Senior;

            //Act
            var actual = emp.SalaryLevel;

            Assert.Equal(expected, actual);
        }
    }
}