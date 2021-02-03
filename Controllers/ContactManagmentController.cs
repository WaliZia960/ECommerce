using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class ContactManagmentController : Controller
    {
        // GET: ContactManagment
        public ActionResult ContactManagmentV()
        {
            return View();
        }




        public string Add_Contact(string contact_Type)
        {
            if (contact_Type.Equals(""))
            {
                return "no";
            }
            else
            {
                ecommerceEntities1 db = new ecommerceEntities1();
                var checkUser = db.Tbl_Contact_Type.Where(rowHere => rowHere.Contact_Type.ToLower() == contact_Type.ToLower()).FirstOrDefault();
                if (checkUser != null)
                {
                    return "Already Present";
                }
                else
                {
                    Tbl_Contact_Type tbl_Contact_Type = new Tbl_Contact_Type { Contact_Type = contact_Type };
                    db.Tbl_Contact_Type.Add(tbl_Contact_Type);
                    db.SaveChanges();
                    return "Added Successfully";
                }
            }
        }


        public JsonResult Fetch_Data()
        {
            ecommerceEntities1 db = new ecommerceEntities1();
            var list = db.Tbl_Contact_Type.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }









    }
}