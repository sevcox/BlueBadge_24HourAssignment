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

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                   Text = model.Text,
                   CommentId = model.CommentId,
                   PostId = model.PostId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
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
                            CommentId = e.CommentId,
                           Text = e.Text,
                           PostId = e.PostId
                        }
                        );

                return query.ToArray();
            }
        }

        public ReplyDetail GeReplyById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                     .Replies
                     .Single(e => e.ReplyId == id);
                return
                 new ReplyDetail
                 {
                     ReplyId = entity.ReplyId,
                     Text = entity.Text,
                     PostId = entity.PostId
                 };

            }
        }

        public bool DeleteReply(int replyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Replies
                    .Single(e => e.ReplyId == replyId);

                ctx.Replies.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
