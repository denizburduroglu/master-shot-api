using MasterShotAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterShotAPI.Services
{
    public interface IPostService
    {
        //Task<List<T>> GetAll();
        Task<Post> GetPost(int id);
        Task<Post> CreatePost(Post entity);
        Task<IEnumerable<Post>> GetPostsBasedOnUserEmails(IEnumerable<string> userEmails);
        //Task<T> Update(T entity);
        //Task<T> Delete(int id);
    }
}
