using SocialMedia.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ReplyDetail
    {
        public int ReplyId { get; set; }
<<<<<<< HEAD
        [Display(Name = "Author")]
=======
        [Display(Name ="Author")]
>>>>>>> 110e4b2e5d4c8babad6701e1e5daeb82cdcce577
        public Guid OwnerId { get; set; }
        public Comment ReplyComment { get; set; }
    }
}
