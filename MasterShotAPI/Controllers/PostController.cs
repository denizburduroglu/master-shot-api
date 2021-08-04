using MasterShotAPI.Models;
using MasterShotAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterShotAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            this._postService = postService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post)
        {
            post.DateCreated = DateTime.UtcNow;
            post.DateModified = DateTime.UtcNow;
            await this._postService.CreatePost(post);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetPost(int id)
        {
            var post = await this._postService.GetPost(id);
            return Ok(post);
        }

        [HttpGet]
        public async Task<IActionResult> GetPostsBasedOnUserEmails(IEnumerable<string> userEmails)
        {
            var posts = await this._postService.GetPostsBasedOnUserEmails(userEmails);
            return Ok(posts);
        }
    }
}
