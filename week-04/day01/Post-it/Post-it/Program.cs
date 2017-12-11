using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a few example post - it objects:
            //an orange with blue text: "Idea 1"
            //a pink with black text: "Awesome"
            //a yellow with green text: "Superb!"


            PostIt Postit1 = new PostIt();
            Postit1.backgroundColor = "red";
            Postit1.Text = "text";
            Postit1.textColor = "blue";

            PostIt Postit2 = new PostIt();
            Postit2.backgroundColor = "orange";
            Postit2.Text = "Idea 1";
            Postit2.textColor = "green";

            PostIt Postit3 = new PostIt();
            Postit1.backgroundColor = "red";
            Postit1.Text = "text";
            Postit1.textColor = "green";

            Console.WriteLine(Postit1.Text);
            Console.WriteLine(Postit1.textColor);
            

            Console.WriteLine(Postit2.Text);
            Console.WriteLine(Postit2.textColor);
            Console.ReadLine();
                       

        }
    }
}
