using MasterShotAPI.Models;
using MasterShotAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterShotAPI.Services
{
    public class PostService : IPostService
    {
        private readonly IGenericRepository<Post> repository;

        public PostService(IGenericRepository<Post> repository)
        {
            this.repository = repository;
        }

        public async Task<Post> CreatePost(Post post)
        {
            post.DateCreated = DateTime.UtcNow;
            post.DateModified = DateTime.UtcNow;
            await this.repository.Add(post);
            return post;
        }

        public async Task<Post> GetPost(int id)
        {
            return await this.repository.Get(id);
        }
    }
}
