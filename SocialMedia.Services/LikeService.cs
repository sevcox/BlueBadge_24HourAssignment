using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateLike(LikeCreate model)
        {
            var entity =
                new Like()
                {
                    OwnerId = _userId,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
        public IEnumerable<LikeListItem> GetLikes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Likes
                    .Select(
                        e =>
                        new LikeListItem
                        {
                            OwnerId = e.OwnerId
                        }
                        );

                return query.ToArray();
            }
        }

        public LikeDetail GetLikeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                     .Likes
                     .Single(e => e.PostId == id);
                return
                 new LikeDetail
                 {
                     LikeId = entity.LikeId,
                     PostId = entity.PostId,
                     OwnerId = entity.OwnerId
                 };

            }
        }

        public bool DeleteLike(int likeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Likes
                    .Single(e => e.LikeId == likeId);

                ctx.Likes.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
    
