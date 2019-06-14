using System.Collections.Generic;
using DAL.Interface;
using DAL.UnitTestContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Logic;
using WebShop_S2.Controllers;
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

            list.Add(new Game() {Id = 1, Price = 105});
            list.Add(new Game() {Id = 2, Price = 35});

            //assert
            Assert.AreEqual(140, logic.GetTotalPrice(list));
        }

        [TestMethod]
        public void PasswordHashCheck()
        {
            //arrange
            AccountLogic logic = new AccountLogic();
            string password = "Test123";
            string hashedPassword = "d9b5f58f0b38198293971865a14074f59eba3e82595becbe86ae51f1d9f1f65e";

            //act
            password = logic.PasswordHash(password);

            //assert
            Assert.AreEqual(hashedPassword, password);
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

        [TestMethod]
        public void RemoveShoppingListTest()
        {
            //arrange
            OrderLogic logic = new OrderLogic();
            logic.AddShoppingCartGame(new Game() {Id = 1});

            //act
            logic.RemoveShoppingCartGame(1);


            //assert
            Assert.AreEqual(0, logic.GetShoppingList().Count);
        }

        [TestMethod]
        public void AddShoppingListTest()
        {
            //arrange
            OrderLogic logic = new OrderLogic();
            Game game = new Game();
            //act
            logic.AddShoppingCartGame(game);

            //assert
            Assert.AreEqual(1, logic.GetShoppingList().Count);
        }

        [TestMethod]
        public void CheckLoginTest()
        {
            //arrange
            IAccountContext context = new TestDateContext();
            AccountLogic logic = new AccountLogic();
            string email = "test@test.nl";
            string password = "Test123";
            
            //act
            bool checklogin = logic.CheckLogin(context,email,password);

            //assert
            Assert.IsTrue(checklogin);
        }

        [TestMethod]
        public void CheckEmailNotTakenTest()
        {
            //arrange
            IAccountContext context = new TestDateContext();
            AccountLogic logic = new AccountLogic();
            string email = "nieuwetest@test.nl";

            //act
            bool checkAccountTaken = logic.CheckAccountTaken(context, email);

            //assert
            Assert.IsFalse(checkAccountTaken);
        }

        [TestMethod]
        public void CheckEmailTakenTest()
        {
            //arrange
            IAccountContext context = new TestDateContext();
            AccountLogic logic = new AccountLogic();
            string email = "test@test.nl";

            //act
            bool checkAccountTaken = logic.CheckAccountTaken(context, email);

            //assert
            Assert.IsTrue(checkAccountTaken);
        }
    }
}
