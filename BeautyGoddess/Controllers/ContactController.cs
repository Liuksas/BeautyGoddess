using System;
using System.Web.Mvc;
using BeautyGoddess.Models;
using BeautyGoddess.Utilities;

namespace BeautyGoddess.Controllers
{
    public class ContactController : BaseController
    {
        [HttpGet]
        public ActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contacts(EmailModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var gmail = new Gmail
                    {
                        Subject = string.Format("Sveitainė: Žinutė gauta nuo: {0}, telefonas: {1};", model.Name, model.Phone),
                        Message = model.Message
                    };
                    gmail.Send();
                    Success("Jūsų žinutė išsiųsta.", true);
                }
                else
                {
                    Error("Duomenys įvesti neteisingai, prašome teisingai užpildyti duomenų formą.", true);
                }
            }
            catch (Exception)
            {
                Error("Sisteminė klaida!", true);
            }
            return View();
        }
    }
}