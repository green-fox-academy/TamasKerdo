using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class Repository
    {
        public PostContext PC { get; set; }

        public Repository(PostContext postContext)
        {
            PC = postContext;
        }

        public List<Post> getAllThePosts()
        {
            return PC.Posts.ToList();
        }

        public void CreateNewPost(string newContent)
        {
            var newPost = new Post();
            newPost.Opinion = 0;
            newPost.PostContent = newContent;
            newPost.TimoeOfThePost = DateTime.Now;
            PC.Posts.Add(newPost);
            PC.SaveChanges();
        }

        public void IncrementPostId(bool inc,long IdOfThePost)
        {
            Post IncrementedPost = PC.Posts.Where(p=>p.PostId == IdOfThePost).FirstOrDefault();
            if (inc)
            {
                IncrementedPost.Opinion++;
            }
            else
            {
                IncrementedPost.Opinion--;
            }
            PC.Posts.Update(IncrementedPost);
            PC.SaveChanges();
        }
    }
}
