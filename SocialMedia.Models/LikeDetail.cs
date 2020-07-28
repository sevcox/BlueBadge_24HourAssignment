using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
   public  class LikeDetail
    {
            public int LikeId { get; set; }
            public int? PostId { get; set; }
            [Display(Name = "Liker")]
            public Guid OwnerId { get; set; }
        
    }
}

