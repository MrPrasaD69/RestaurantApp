using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repository
{
    public class ItemRepository
    {
        private RestaurantDBEntities restdb;
        public ItemRepository()
        {
            restdb = new RestaurantDBEntities();

        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in restdb.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemID.ToString(),
                                      Selected = true
                                  }).ToList();
            return objselectListItems;
        }
    }
}