using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class RoleManagmentController : Controller
    {
        // GET: RoleManagment
        public ActionResult RoleManagmentV()
        {
            return View();
        }


        public string Add_Role(string role_Type)
        {
            if (role_Type.Equals(""))
            {
                return "no";
            }
            else
            {
                ecommerceEntities1 db = new ecommerceEntities1();
                var checkUser = db.Tbl_Role_Type.Where(rowHere => rowHere.Role_Type.ToLower() == role_Type.ToLower()).FirstOrDefault();
                if (checkUser != null)
                {
                    return "Already Present";
                }
                else
                {
                    Tbl_Role_Type tbl_Role_Type = new Tbl_Role_Type { Role_Type = role_Type };
                    db.Tbl_Role_Type.Add(tbl_Role_Type);
                    db.SaveChanges();
                    return "Added Successfully";
                }
            }
        }


        public JsonResult Fetch_Data()
        {
            ecommerceEntities1 db = new ecommerceEntities1();
            var list = db.Tbl_Role_Type.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

    
    }
}