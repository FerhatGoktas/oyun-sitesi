using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace oyun_sitesi.Models
{
    public class Games_Categories
    {
        public Games Games { get; set; }
        [ForeignKey("Games")]
        public int game_Id { get; set; }
        public Categories Categories { get; set; }
        [ForeignKey("Categories")]
        public int category_Id { get; set; }
    }
}