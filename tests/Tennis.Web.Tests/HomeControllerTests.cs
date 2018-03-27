using System;
using NUnit.Framework;
using Tennis.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tennis.Web.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void LandingPageTitleIsFirstPage()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ViewData["Title"], Is.EqualTo("First page"));
        }
    }
}