using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class RegisterManagmentController : Controller
    {
        // GET: RegisterManagment
        public ActionResult RegisterManagmentV()
        {
            return View();
        }





        public string Add_Register(string register_Type)
        {
            if (register_Type.Equals(""))
            {
                return "no";
            }
            else
            {
                ecommerceEntities1 db = new ecommerceEntities1();
                var checkUser = db.Tbl_Reg_Mode_Type.Where(rowHere => rowHere.Reg_Mode_Type.ToLower() == register_Type.ToLower()).FirstOrDefault();
                if (checkUser != null)
                {
                    return "Already Present";
                }
                else
                {
                    Tbl_Reg_Mode_Type tbl_Reg_Mode_Type = new Tbl_Reg_Mode_Type { Reg_Mode_Type = register_Type };
                    db.Tbl_Reg_Mode_Type.Add(tbl_Reg_Mode_Type);
                    db.SaveChanges();
                    return "Added Successfully";
                }
            }
        }


        public JsonResult Fetch_Data()
        {
            ecommerceEntities1 db = new ecommerceEntities1();
            var list = db.Tbl_Reg_Mode_Type.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }














    }
}