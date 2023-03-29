using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst_2.Entities
{
    [Table("Ders")]
    public class Ders
    {
        [Key]
        public int DersId { get; set; }
        public string DersAdı { get; set; }
        public int DersSaati { get; set; }
        public List<Ogretmen> Ogretmenler { get; set; }
        //dersin öğretmenleri var.
        public List<Ogrenci> Ogrenciler { get; set; }
        //dersin öğrencileri var.

    }
}
