using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Server_EFCore.Models
{
    public class GroupMenu
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "ประเภทอาหาร")]
        public string GroupNameMenu { get; set; }
    }
}
