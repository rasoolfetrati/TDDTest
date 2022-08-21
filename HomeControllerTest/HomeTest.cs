using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WepAppTDD.Controllers;
using WepAppTDD.Models;

namespace HomeControllerTest
{
    public class HomeTest
    {
        [Fact]
        public void Home_Controller_Test()
        {
            HomeController controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
        [Theory]
        [InlineData("1,3", 4)]
        [InlineData("", 0)]
        [InlineData("0", 0)]
        [InlineData("9,5,5,", 19)]
        public void Sum_Test(string numbers, int expected)
        {
            //Arrage
            Sum sum = new Sum();

            //Act
            var result = sum.Execute(numbers);
            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData("1,3", 4)]
        [InlineData("", 0)]
        [InlineData("0", 0)]
        [InlineData("9,5,5,", 19)]
        public void SumController_Test(string numbers, int expected)
        {
            //Arrage
            HomeController controller = new();
            //Act
            var result = controller.SumExecute(numbers);
            //Assert
            Assert.IsType<JsonResult>(result);

        }
    }
}
