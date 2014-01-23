using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RnD.ShellSample.Models;
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

        public ActionResult TreeView()
        {
            return View();
        }

        //[HttpPost]
        public ActionResult GetTreeData(string root)
        //public ActionResult GetTreeData()
        {
            //string root = string.Empty;
            var dataList = new List<TreeViewModel>()
                            {
                              new TreeViewModel  {text = "A", id = "1"},
                              new TreeViewModel  {text = "B", id = "2"},
                              new TreeViewModel  {text = "C", id = "3"},
                              new TreeViewModel  {text = "E", id = "4"},
                              new TreeViewModel  {text = "F", id = "5"},
                              new TreeViewModel  {text = "G", id = "6"},
                              new TreeViewModel  {text = "H", id = "7"},
                              new TreeViewModel  {text = "I", id = "8"},
                              new TreeViewModel  {text = "J", id = "9"},
                              new TreeViewModel  {text = "K", id = "10"},

                              new TreeViewModel  {text = "L", id = "11"},
                              new TreeViewModel  {text = "M", id = "12"},
                              new TreeViewModel  {text = "N", id = "13"},
                              new TreeViewModel  {text = "O", id = "14"},
                              new TreeViewModel  {text = "P", id = "15"},
                              new TreeViewModel  {text = "Q", id = "16"},
                              new TreeViewModel  {text = "S", id = "17"},
                              new TreeViewModel  {text = "T", id = "18"},
                              new TreeViewModel  {text = "U", id = "19"},
                              new TreeViewModel  {text = "V", id = "20"}

                            };

            var nodes = new List<TreeViewModel>();

            if (root == "source")
            {
                var partTypes = dataList.ToList().OrderBy(pt => pt.text);

                foreach (var partType in partTypes)
                {
                    nodes.Add(new TreeViewModel
                    {
                        text = partType.text,
                        id = partType.id,
                        hasChildren = true
                    });
                }
            }
            else
            {
                var parts = dataList.Where(p => p.text == root).ToList();
                foreach (var part in parts)
                {
                    nodes.Add(new TreeViewModel
                    {
                        text = part.text,
                        id = part.id
                    });
                }
            }

            return Json(nodes.ToArray(), JsonRequestBehavior.AllowGet);
        }

    }
}
