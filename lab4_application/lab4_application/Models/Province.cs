using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab4_application.Models
{
    public class Province
    {
        [Key]
        public string ProviniceCode { get; set; }
        public string ProviceName { get; set; }

        public List<City> Cities { get; set; }

    }
}