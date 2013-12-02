using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.ShellSample.ViewModels
{
    public class ShellRewardsPromotionViewModel
    {
        public int PriorityId { get; set; }
        public string Priority { get; set; }
        public string PromoType { get; set; }
        public int OfferId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
    }
}