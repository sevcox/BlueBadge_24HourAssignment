using SocialMedia.Data;
using System;
<<<<<<< HEAD
using System.CodeDom;
=======
>>>>>>> 110e4b2e5d4c8babad6701e1e5daeb82cdcce577
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ReplyCreate
    {
        [Required]
        [MaxLength(8000)]
        public Comment ReplyComment { get; set; }
    }
}
