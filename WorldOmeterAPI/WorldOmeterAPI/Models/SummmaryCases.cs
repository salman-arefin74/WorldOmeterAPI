using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOmeterAPI.Models
{
    public class SummmaryCases
    {
        [Key]
        public int ScID { get; set; }
        public int activeInfected { get; set; }
        public int activeMild { get; set; }
        public int activeSerious { get; set; }
        public int outcomeClosed { get; set; }
        public int recovered { get; set; }
        public int deaths { get; set; }
    }
}
