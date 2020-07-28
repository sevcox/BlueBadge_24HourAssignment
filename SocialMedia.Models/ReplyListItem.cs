<<<<<<< HEAD
﻿using System;
=======
﻿using SocialMedia.Data;
using System;
>>>>>>> 110e4b2e5d4c8babad6701e1e5daeb82cdcce577
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ReplyListItem
    {
        public int CommentId { get; set; }
        public Comment ReplyComment { get; set; }
    }
}
