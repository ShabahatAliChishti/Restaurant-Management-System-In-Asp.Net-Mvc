using Restaurant_Management_System_MVc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Management_System_MVc.Respositories
{
    public class ItemRepository
    {
        RestaurantDbEntities db;
        public ItemRepository()
        {
            db = new RestaurantDbEntities();
        }
        public IEnumerable<SelectListItem> GetAllItems()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in db.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.Name,
                                      Value = obj.ItemID.ToString(),
                                      Selected = true

                                  }).ToList();
            return objSelectListItems;
        }
    }
}