using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repository
{
    public class CustomerRepository
    {
        private RestaurantDBEntities restdb;
        public CustomerRepository()
        {
            restdb = new RestaurantDBEntities();

        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in restdb.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerID.ToString(),
                                      Selected = true
                                  }).ToList();
            return objselectListItems;
        }
    }
}