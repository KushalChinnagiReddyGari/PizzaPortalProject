using NUnit.Framework;
using NUnit.Framework.Legacy;
using PizzaPortalProject.Controllers;
using PizzaPortalProject.Models;
using System.Web.Mvc;

namespace TestLibraryPizzaProject
{
    [TestFixture]
    public class ControllerTest
    {
   

        [Test]
        public void TestPizzaSelectionPage()
        {
            PizzaController controller = new PizzaController();
            var result = controller.SelectedItems(1) as ViewResult;
            ClassicAssert.IsNotNull(result);
            ClassicAssert.IsNotNull(result.Model);
            ClassicAssert.IsInstanceOf(typeof(PizzaModel), result.Model);
        }
        [Test]
        public void TestOrderConfirmationPage()
        {
            PizzaController controller = new PizzaController();
            controller.TempData["TotalPrice"] = 503.65f;
            controller.TempData["Address"] = "Varanasi";
            var result = controller.PaymentMode() as ViewResult;
            ClassicAssert.IsNotNull(result);
            ClassicAssert.IsNotNull(result.ViewBag.TotalPrice);
            ClassicAssert.IsNotNull(result.ViewBag.Address);
        }

        [Test]
        public void TestOrderSuccessPage()
        {
            PizzaController controller = new PizzaController();
            string expected = "OrderSuccess";
            var result = controller.OrderSuccess() as ViewResult;
            ClassicAssert.AreEqual(expected, result.ViewName);
        }
    }
}