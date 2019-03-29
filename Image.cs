using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oop
{
    public class Image : Post
    {
        private ImageType _type;
        public Image(string pDate, string txt, ImageType type)
        {
            _postDate = pDate;
            _text = txt;
            _type = type;
        }
        public ImageType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public override void Print()
        {
            Console.WriteLine("\t{0} ({1} image) --posted on {2}", _text, _type, _postDate);
        }
    }
}

