using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentListItem
    {
        public int CommentId { get; set; }
        [Display(Name= "Author")]
        public Guid OwnerId { get; set; }
        [Display(Name = "Comment")]
        public string Text { get; set; }
        public int PostId { get; set; }
    }
}
