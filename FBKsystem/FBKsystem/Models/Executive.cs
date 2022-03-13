using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Models
{
    public class Executive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Position { get; set; }
        public string Level { get; set; }
        public string Tenure { get; set; }
        public string RegDate { get; set; }
        //public Member Member { get; set; }
    }
}
