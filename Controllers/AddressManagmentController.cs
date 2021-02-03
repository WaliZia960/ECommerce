using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class AddressManagmentController : Controller
    {
        // GET: AddressManagment
        public ActionResult AddressManagmentV()
        {
            return View();
        }


        public string Add_Address(string address_Type) {
            if (address_Type.Equals("")) {
                return "no";
            }
            else {
                ecommerceEntities1 db = new ecommerceEntities1();
                var checkUser = db.Tbl_Address_Type.Where(rowHere => rowHere.Address_Type.ToLower() == address_Type.ToLower()).FirstOrDefault();
                if (checkUser != null) {
                    return "Already Present";
                }
                else {
                    Tbl_Address_Type tbl_Address_Type = new Tbl_Address_Type { Address_Type = address_Type };
                    db.Tbl_Address_Type.Add(tbl_Address_Type);
                    db.SaveChanges();
                    return "Added Successfully";
                }
            }
        }


        public JsonResult Fetch_Data()
        {
            ecommerceEntities1 db = new ecommerceEntities1();
            var list = db.Tbl_Address_Type.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }


    }
}