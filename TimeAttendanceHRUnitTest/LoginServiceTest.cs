using NUnit.Framework;
using AppBAL.Sevices.Login;
using System;
using System.IO;
using Moq;
namespace TimeAttendanceHRUnitTest
{
    public class LoginServiceTest
    {
        private const string userName = "Admin";
        private const string password = "123";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //using (var sw = new StringWriter())
            //{
            //    ILoginService _loginService;
            //    var mockLogin = new Mock<ILoginService>();
            //    //LoginService logService = new LoginService();
            //    Console.SetOut(sw);
            //    logService.ValidateUser()

            //    var result = sw.ToString().Trim();
            //    Assert.AreEqual(Expected, result);
            //}

            //Assert.Pass();
        }

    }
}
