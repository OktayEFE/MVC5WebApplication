using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class CountryInfo
    {
        [Key]
        public int CountryID { get; set; }
        [StringLength(20)]
        public string CountryName { get; set; }
        [StringLength(20)]
        public string Capital { get; set; }
        [StringLength(8)]
        public string CountryCode { get; set; }
        [StringLength(8)]
        public string CurrencyUnit { get; set; }
        public bool Status { get; set; }
    }
}
