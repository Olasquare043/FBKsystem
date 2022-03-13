using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBKsystem.Models
{
    public class Biodata
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String MemberId { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Othername { get; set; }
        public String Nickname { get; set; }
        public String Gender { get; set; }
        public String Age { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Password { get; set; }
        public String RegDate { get; set; }
        public List<OriginDetails> OriginDetails { get; set; }
        public List<SocialMedia> SocialMedia { get; set; }
        public List<Executive> Executive { get; set; }
        public List<Dues> Dues { get; set; }

    }
}
