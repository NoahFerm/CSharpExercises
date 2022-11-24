using Exercise1.UI;
using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1.Helpers;
using Moq;

namespace EmployeeList.XUnitTest
{
    
    public class UtilTests
    {
        [Fact]
        public void AskForString_ShouldReturnString_WithOurMock() //Dålig
        {
            const string expected = "SomeInput";
            var mockUI = new MockUI();
            mockUI.SetInput = expected;

            var actual = Util.AskForString("", mockUI);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AskForString_ShouldReturnString_WithMoq() //BRA
        {
            const string expected = "SomeInput";
            var ui = new Mock<IUI>();
            ui.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForString("", ui.Object);

            Assert.Equal(expected, actual);
        }
    }
}
