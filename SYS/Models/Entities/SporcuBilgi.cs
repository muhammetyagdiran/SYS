using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SYS.Models.Entities
{
    public class SporcuBilgi
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Ad { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Soyad { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string DogumYeri { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string DogumTarihi { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string EvTelefon { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string email { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string EvAdresi { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string KanGrubu { get; set; }
        [Column(TypeName = "int")]
        public int Boy { get; set; }
        [Column(TypeName = "int")]
        public int Kilo { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string OkuduguOkul { get; set; }
        
    }
}
