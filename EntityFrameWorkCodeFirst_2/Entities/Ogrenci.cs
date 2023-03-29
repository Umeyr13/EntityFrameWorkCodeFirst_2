using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst_2.Entities
{
    [Table("Ogrenci")]
    public class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }
        public string Adı { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public List<Ders> Dersler { get; set; }
        //Bir öğrencinin dersleri var.
        public Veli Veli { get; set; }
    }
}
