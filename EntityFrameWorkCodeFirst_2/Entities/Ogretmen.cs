using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst_2.Entities
{
    [Table("Ogretmen")]//tablo adı verdik
    public class Ogretmen
    {
        [Key]
        public int OgretmenID { get; set; }
        public string Adı { get; set; }
        public string Soyadi { get; set; }
        public string TCNo { get; set; }
        public Ders Ders { get; set; }
        //ogretmenin bir dersi var.

        public int DersId { get; set; }

    }
}
