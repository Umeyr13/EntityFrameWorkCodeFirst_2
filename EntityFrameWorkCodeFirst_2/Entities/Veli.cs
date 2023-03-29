using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst_2.Entities
{
    [Table("Veli")]
    public class Veli
    {
        [Key]
        public int VeliID { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
      
        List<Ogrenci> Ogrenciler { get; set; }

    }
}
