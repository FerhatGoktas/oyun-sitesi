using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace oyun_sitesi.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int category_Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required]
        public string category_Name { get; set; }
    }
}