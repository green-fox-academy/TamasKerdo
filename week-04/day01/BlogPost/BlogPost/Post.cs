using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Post
    {
        
        public string Authorname { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public string PublicationDate { get; private set; }

        public Post(string Authorname, string Title, string Text, string PublicationDate)
        {
            if (Authorname == "paraszt")
            {
                Console.WriteLine("Please do not use dirty words!");
                this.Authorname = "foldmuves";
            }
            else
            {
                this.Authorname = Authorname;
            }

            this.Title = Title;
            this.Text = Text;
            this.PublicationDate = PublicationDate;
        }
    }
}
