using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class CommentService
    {
        private readonly Guid _userId;

        private CommentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateComment(CommentCreate model)
        {
            var entity =
                new Comment()
                {
                    OwnerId = _userId,
<<<<<<< HEAD
                    PostId = model.PostId,
                    CommentId = model.CommentId,
=======
>>>>>>> 110e4b2e5d4c8babad6701e1e5daeb82cdcce577
                    Text = model.Text,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
<<<<<<< HEAD

        public IEnumerable<CommentListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Comments
                    .Where(e => OwnerId == _userId && PostId == e.PostId)
                    .Select(
                        e =>
                        new CommentListItem
                        {
                            OwnerId = _userId,
                            CommentId = e.CommentId,
                            Text = e.Text
                        }

                        );
                return query.ToArray();


            }
        }

        public bool DeleteCommment(int commentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == commentId);

=======
        public IEnumerable<CommentListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Comments
                    .Select(
                        e =>
                        new CommentListItem
                        {
                            OwnerId = _userId,
                            CommentId = e.CommentId,
                            Text = e.Text
                        }

                        );
                return query.ToArray();
            }
        }
        public CommentDetail GetCommentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                     .Comments
                     .Single(e => e.CommentId == id);
                return
                 new CommentDetail
                 {
                     CommentId = entity.CommentId,
                     Text = entity.Text,
                     OwnerId = entity.OwnerId,
                     PostId = entity.PostId
                 };
            }
        }

        public bool DeleteCommment(int commentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Comments
                    .Single(e => e.CommentId == commentId);

>>>>>>> 110e4b2e5d4c8babad6701e1e5daeb82cdcce577
                ctx.Comments.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
