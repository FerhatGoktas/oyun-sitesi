using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace oyun_sitesi.Models
{
    public class Users
    {
        [Key]
        [Required]
        public int user_Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public string user_Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(80)]
        public string user_Email { get; set;}

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string user_Authorization { get; set;}
    }
}