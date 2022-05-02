using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Active_cloud_site_5.Models
{
    public class Master_Menu
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MenuID { get; set; }
        public string Menu_name { get; set; }

        public int DietID { get; set; }
    }
}
