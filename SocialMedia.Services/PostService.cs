using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(PostCreate model) //errors will not be settle until PostCreate model is made
        {
            var entity =
                new Post()
                {
                    OwnerId = _userId,
                    Title = model.Title,
                    Text = model.Text
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
        public IEnumerable<PostListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Posts
                    .Select(
                        e =>
                        new PostListItem
                        {
                            PostId = e.PostId,
                            Title = e.Title,
                            Text = e.Text
                        }

                        );

                return query.ToArray();
            }
        }

        public PostDetail GetPostById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                     .Posts
                     .Single(e => e.PostId == id);
                return
                 new PostDetail
                 {
                     PostId = entity.PostId,
                     Title = entity.Title,
                     Text = entity.Text,
                     OwnerId = entity.OwnerId

                 };

            }
        }

        public bool DeletePost(int postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == postId);

                ctx.Posts.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
