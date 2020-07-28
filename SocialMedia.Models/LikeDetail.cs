using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
<<<<<<< HEAD
   public  class LikeDetail
    {
            public int LikeId { get; set; }
            public int? PostId { get; set; }
            [Display(Name = "Liker")]
            public Guid OwnerId { get; set; }
        
    }
}

=======
    public class LikeDetail
    {
        public int LikeId { get; set; }
        public int? PostId { get; set; }
        [Display(Name ="Liker")]
        public Guid OwnerId { get; set; }
    }
}
>>>>>>> 888021804e26c4e2c538cbee658991d0577fd893
