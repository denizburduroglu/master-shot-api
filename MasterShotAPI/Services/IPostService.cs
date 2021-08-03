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
        //Task<T> Get(int id);
        Task<Post> CreatePost(Post entity);
        //Task<T> Update(T entity);
        //Task<T> Delete(int id);
    }
}
