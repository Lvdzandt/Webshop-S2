using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Logic;
using WebShop_S2.Controllers;
using WebShop_S2.Models;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestWebShop
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalOrderPrice()
        {
            //arrange

            List<Game> list = new List<Game>();
            OrderLogic logic = new OrderLogic();
            //act

            list.Add(new Game() { Id = 1, Price = 105 });
            list.Add(new Game() { Id = 2, Price = 35 });

            //assert
            Assert.AreEqual(140,logic.GetTotalPrice(list));
        }

        [TestMethod]
        public void PasswordHashCheck()
        {
            //arrange
            AccountLogic logic = new AccountLogic();
            string password = "Test123";
            string HashedPassword = "d9b5f58f0b38198293971865a14074f59eba3e82595becbe86ae51f1d9f1f65e";

            //act
            password = logic.PasswordHash(password);

            //assert
            Assert.AreEqual(password,HashedPassword);
        }

        [TestMethod]
        public void LoginControllerTest()
        {
            //arrange
            AccountController controller = new AccountController();

            //act
            ViewResult result = controller.Login() as ViewResult;

            //assert
            Assert.IsNotNull(result);
        }
    }
}
