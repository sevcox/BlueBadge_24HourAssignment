﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentDetail
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        [Display(Name = "Author")]
        public Guid OwnerId { get; set; }
        public int PostId { get; set; }
    }
}
