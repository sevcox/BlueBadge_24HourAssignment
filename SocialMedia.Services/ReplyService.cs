using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;

        private ReplyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReplu(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    OwnerId = _userId,
                    ReplyComment = model.ReplyComment
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<ReplyListItem> GetReplies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Replies
                    .Select(
                        e =>
                        new ReplyListItem
                        {
                           

                        );
                return query.ToArray();


            }
        }

        public ReplyDetail GetReply(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.ReplyId == id);
                return
                    new ReplyDetail
                    {
                        ReplyId = entity.ReplyId,



                    };

            }
        }

        public bool DeleteReply(int replyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.ReplyId == replyId);

                ctx.Comments.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
