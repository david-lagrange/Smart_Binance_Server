using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Binance_Server.Entities
{
    [Table("ApplicaitonUser")]
    public class ApplicationUser
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}


