using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace FBKsystem.Models
{
    public class OriginDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int MemberID { get; set; }
        public String StreetNo { get; set; }
        public String StreetName { get; set; }
        public String NearestBustop { get; set; }
        public int PostalCode { get; set; }
        public String State { get; set; }
        public String LGA { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public Biodata Member { get; set; }

    }
}
