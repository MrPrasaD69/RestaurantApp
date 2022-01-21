using RestaurantApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CustomerRepository objcustomerRepository = new CustomerRepository();
            ItemRepository objitemRepository = new ItemRepository();
            PaymentRepository objpaymentRepository = new PaymentRepository();

               var objectMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>> 
                (objcustomerRepository.GetAllCustomers(), objitemRepository.GetAllItems(), objpaymentRepository.GetAllPaymentType());
            return View(objectMultipleModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}