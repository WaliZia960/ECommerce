using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class StatusManagmentController : Controller
    {
        // GET: StatusManagment
        public ActionResult StatusManagmentV()
        {
            return View();
        }







        public string Add_Status(string status_Type)
        {
            if (status_Type.Equals(""))
            {
                return "no";
            }
            else
            {
                ecommerceEntities1 db = new ecommerceEntities1();
                var checkUser = db.Tbl_Status_Type.Where(rowHere => rowHere.Status_Type.ToLower() == status_Type.ToLower()).FirstOrDefault();
                if (checkUser != null)
                {
                    return "Already Present";
                }
                else
                {
                    Tbl_Status_Type tbl_Status_Type = new Tbl_Status_Type { Status_Type = status_Type };
                    db.Tbl_Status_Type.Add(tbl_Status_Type);
                    db.SaveChanges();
                    return "Added Successfully";
                }
            }
        }


        public JsonResult Fetch_Data()
        {
            ecommerceEntities1 db = new ecommerceEntities1();
            var list = db.Tbl_Status_Type.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }











    }
}