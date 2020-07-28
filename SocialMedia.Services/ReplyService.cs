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
                    OwnerId = _userId,
                    ReplyComment = model.ReplyComment
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
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
                            ReplyComment = e.ReplyComment
                        }    
                        );
                return query.ToArray();

            }
        }

        public ReplyDetail GetRepById(int id) 
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Replies.Single(e => e.ReplyId == id);
                return
                    new ReplyDetail 
                    {
                        ReplyId = entity.ReplyId,
                        ReplyComment = entity.ReplyComment,
                        OwnerId = entity.OwnerId
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
