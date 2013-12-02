using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RnD.ShellSample.ViewModels;

namespace RnD.ShellSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public JsonResult GetData()
        {
            var shellRewardsPromotionViewModels = new List<ShellRewardsPromotionViewModel>
                               {
                                   new ShellRewardsPromotionViewModel{PriorityId = 1, Priority = "ABC", PromoType = "A-TYPE", OfferId = 1, Name = "ABC-NAME", Description = "ABC-DES", StartDate = DateTime.Now, EndDate = DateTime.Now, Status = 1},
                                   new ShellRewardsPromotionViewModel{PriorityId = 2, Priority = "ABC", PromoType = "A-TYPE", OfferId = 1, Name = "ABC-NAME", Description = "ABC-DES", StartDate = DateTime.Now, EndDate = DateTime.Now, Status = 1},
                                   new ShellRewardsPromotionViewModel{PriorityId = 3, Priority = "ABC", PromoType = "A-TYPE", OfferId = 1, Name = "ABC-NAME", Description = "ABC-DES", StartDate = DateTime.Now, EndDate = DateTime.Now, Status = 1},
                                   new ShellRewardsPromotionViewModel{PriorityId = 4, Priority = "ABC", PromoType = "A-TYPE", OfferId = 1, Name = "ABC-NAME", Description = "ABC-DES", StartDate = DateTime.Now, EndDate = DateTime.Now, Status = 1},
                                   new ShellRewardsPromotionViewModel{PriorityId = 5, Priority = "ABC", PromoType = "A-TYPE", OfferId = 1, Name = "ABC-NAME", Description = "ABC-DES", StartDate = DateTime.Now, EndDate = DateTime.Now, Status = 1},
                                   new ShellRewardsPromotionViewModel{PriorityId = 6, Priority = "ABC", PromoType = "A-TYPE", OfferId = 1, Name = "ABC-NAME", Description = "ABC-DES", StartDate = DateTime.Now, EndDate = DateTime.Now, Status = 1},
                                   new ShellRewardsPromotionViewModel{PriorityId = 7, Priority = "ABC", PromoType = "A-TYPE", OfferId = 1, Name = "ABC-NAME", Description = "ABC-DES", StartDate = DateTime.Now, EndDate = DateTime.Now, Status = 1}
                               };

            return Json(shellRewardsPromotionViewModels, JsonRequestBehavior.AllowGet);
        }
    }
}
