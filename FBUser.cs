using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oop
{
    public class FBUser
    {
        private string _name;
        private List<Post> _posts;
        public FBUser(string name)
        {
            _name = name;
            _posts = new List<Post>();
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public List<Post> Posts
        {
            get
            {
                return _posts;
            }
        }
        public Post this[int i]
        {
            get
            {
                return _posts[i];
            }
        }
        public int PostCount
        {
            get
            {
                return _posts.Count;
            }
        }
        public void AddPost(Post post)
        {
            _posts.Add(post);
        }
        public void PrintAllPost()
        {
            Console.WriteLine("{0} has {1} posts in total", _name, PostCount);
            foreach (Post i in _posts)
                i.Print();
        }
    }
}

