using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentEdit
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        [Display(Name = "Author")]
        public int PostId { get; set; }

    }
}
