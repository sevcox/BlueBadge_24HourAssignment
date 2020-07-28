using SocialMedia.Data;
using System;
using System.CodeDom;
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
        public string Text { get; set; }
        public int CommentId { get; set; }
        public int PostId { get; set; }
    }
}
