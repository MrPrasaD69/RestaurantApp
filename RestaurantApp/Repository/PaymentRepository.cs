using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repository
{
    public class PaymentRepository
    {
        private RestaurantDBEntities restdb;
        public PaymentRepository()
        {
            restdb = new RestaurantDBEntities();

        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in restdb.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text=obj.PaymentTypeName,
                                      Value=obj.PaymentTypeID.ToString(),
                                      Selected= true
                                  }).ToList();
            return objselectListItems;
        }

    }     
}
