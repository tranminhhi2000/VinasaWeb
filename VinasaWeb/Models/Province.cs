using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinasaWeb.Models
{
    public class Province
    {
        public int Id { get; set; }

        [Display(Name = "Tên")]
        public string Title { get; set; }
    }
}