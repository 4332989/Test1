using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oop
{
    public abstract class Post
    {
        protected string _postDate;
        protected string _text;
        public string PostDate
        {
            get
            {
                return _postDate;
            }
            set
            {
                _postDate = value;
            }
        }
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        public abstract void Print();
    }
}

