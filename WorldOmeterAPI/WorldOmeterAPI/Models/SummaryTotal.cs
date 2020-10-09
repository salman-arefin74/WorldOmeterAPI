using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOmeterAPI.Models
{
    public class SummaryTotal
    {
        [Key]
        public int StID { get; set; }
        public int TotalCases { get; set; }
        public int DeathCases { get; set; }
        public int RecoveredCases { get; set; }
    }
}
