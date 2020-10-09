using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOmeterAPI.Models
{
    public class CountryView
    {
        [Key]
        public int CvID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string country { get; set; }
        public int totalCases { get; set; }
        public int newCases { get; set; }
        public int totalDeaths { get; set; }
        public int newDeaths { get; set; }
        public int totalRecovered { get; set; }
        public int activeCases { get; set; }
    }
}
