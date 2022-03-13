using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Models
{
    public class Dues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string DuesName { get; set; }
        public int Amount { get; set; }
        public string PaidDate { get; set; }

        Biodata Member { get; set; }
    }
}
