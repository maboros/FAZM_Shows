using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace FAZM_Shows.Models.Show
{
    public class Show
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(2000)")]
        [Required]
        [DisplayName("Sekcija")]
        public string section { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required]
        [DisplayName("Naziv Nastupa")]
        public string name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [DisplayName("Lokacija")]
        public string location { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [DisplayName("Opis")]
        public string description { get; set; }
        [Column(TypeName = "nvarchar(2000)")]
        [DisplayName("Datum")]
        public DateTime date { get; set; }

    }
}