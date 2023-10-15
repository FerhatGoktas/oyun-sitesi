using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace oyun_sitesi.Models
{
    public class Score_Games_Users
    {
        public Games Games { get; set; }
        public Users Users { get; set; }
        [ForeignKey("Games")]
        public int game_Id { get; set; }

        [ForeignKey("Users")]
        public int user_Id { get; set; }

        [Required]
        public int user_Score { get; set; }


        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string user_Comment { get; set;}
    }
}