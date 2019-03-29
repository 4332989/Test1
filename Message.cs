using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oop
{
    public class Message : Post
    {
        public Message(string pDate, string txt)
        {
            _postDate = pDate;
            _text = txt;
        }
        public override void Print()
        {
            Console.WriteLine("\t{0} --posted on {1}", _text, _postDate);
        }
    }
}

