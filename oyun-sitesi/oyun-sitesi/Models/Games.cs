using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace oyun_sitesi.Models
{
    public class Games
    {
        [Key]
        [Required]
        public int game_Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string game_Name { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string description { get; set;}

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string file { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string image { get; set; }
    }
}