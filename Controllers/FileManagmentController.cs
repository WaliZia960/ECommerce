using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class FileManagmentController : Controller
    {
        // GET: FileManagment
        public ActionResult FileManagmentV()
        {
            return View();
        }


        public string Add_File(string file_Type)
        {
            if (file_Type.Equals(""))
            {
                return "no";
            }
            else
            {
                ecommerceEntities1 db = new ecommerceEntities1();
                var checkUser = db.Tbl_File_Type.Where(rowHere => rowHere.File_Type.ToLower() == file_Type.ToLower()).FirstOrDefault();
                if (checkUser != null)
                {
                    return "Already Present";
                }
                else
                {
                    Tbl_File_Type tbl_File_Type = new Tbl_File_Type { File_Type = file_Type };
                    db.Tbl_File_Type.Add(tbl_File_Type);
                    db.SaveChanges();
                    return "Added Successfully";
                }
            }
        }


        public JsonResult Fetch_Data()
        {
            ecommerceEntities1 db = new ecommerceEntities1();
            var list = db.Tbl_File_Type.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }


















    }
}