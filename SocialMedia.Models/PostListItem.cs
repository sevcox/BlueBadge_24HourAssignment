using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class PostListItem
    {
        public int PostId { get; set; }
        [Display(Name = "Author")]
        public Guid OwnerId { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name = "Post")]
        public string Text { get; set; }
    }
}