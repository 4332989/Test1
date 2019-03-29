using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oop
{
    class Program
    {
        public static void Main(string[] args)
        {
            FBUser u1 = new FBUser("goh");
            Post[] p =
            {
                new Message("2018-10-12", "I am doing final OOP revision"),
                new Image("2018-10-12", "OOP concept map", ImageType.Colored),
                new Image("2018-10-12", "OOP class diagram", ImageType.Greyscale),
                new Message("2018-10-13", "I am in exam hall")
            };
            foreach (Post b in p)
                u1.AddPost(b);
            u1.PrintAllPost();
            Console.ReadKey();
        }
    }
}

