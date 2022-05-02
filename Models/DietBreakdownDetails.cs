using System;
using System.Collections.Generic;

namespace Active_cloud_site_5.Models
{
    public class Diet_breakdown_details
    {
        public Decimal Calories { get; set; }
        public Decimal Fat { get; set; }
        public Decimal Carbs { get; set; }
        public Decimal Protein { get; set; }
        public List<Diet_and_menu_details> Diet_And_Menus { get; set; }
    }

}  