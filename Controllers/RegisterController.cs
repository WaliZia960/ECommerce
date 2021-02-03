using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }


      

        // this function is inserting data in 4 tables users, roles, status and register type.
        public string Register_User(string name, string email, string pass, string re_pass)
        {
            if (email.Equals("") || pass.Equals("") || re_pass.Equals("") || pass != re_pass) {
                return "no";
            }
            else {
                ecommerceEntities1 db = new ecommerceEntities1();
                var checkUser = db.Tbl_User.Where(rowHere => rowHere.Email.ToLower() == email.ToLower()).FirstOrDefault();
                if (checkUser != null) {

                    return "Already Present";
                }
                else {

                    int Reg_Mode_Type_Id = 1, Role_Type_Id = 1, Status_Type_Id = 5, User_Id = 0;

                    Tbl_User tbl_User = new Tbl_User { Name = name, Email = email, Password = Encode.EncodePasswordToBase64(pass), Role_Type_Id = Role_Type_Id, Reg_Mode_Type_Id = Reg_Mode_Type_Id, Status_Type_Id = Status_Type_Id };
                    db.Tbl_User.Add(tbl_User);
                    db.SaveChanges();

                    var users = db.Tbl_User.ToList();
                    foreach (var user in users)
                    {
                        if(@user.Email == email)
                        {
                            User_Id = user.User_Id;
                        }
                    }

                    // MY FIRST OFFICIAL STORED FROCEDURE
                    db.Insert_To_Tbl_Role(User_Id, Role_Type_Id);

                    db.Insert_To_Tbl_Status(User_Id,Status_Type_Id);

                    db.Insert_To_Tbl_Reg_Mode(User_Id,Reg_Mode_Type_Id);

                    return "Registered Successfully, check mail to confirm";
                }
            }
        }









    }
}