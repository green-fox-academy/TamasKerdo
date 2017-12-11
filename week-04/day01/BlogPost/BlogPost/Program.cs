using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var PostMessage1 = new Post("paraszt", "War and peace", "very nice book", "2000.05.04.");
            var PostMessage2 = new Post("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");            
            var PostMessage3 = new Post("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");

            Console.WriteLine(PostMessage1.Authorname+ PostMessage1.Text+ PostMessage1.Title+ PostMessage1.PublicationDate+ "/n");
            Console.WriteLine(PostMessage2.Authorname+ PostMessage2.Text+ PostMessage2.Title+ PostMessage2.PublicationDate+ "/n");
            Console.WriteLine(PostMessage3.Authorname+ PostMessage3.Text+ PostMessage3.Title+ PostMessage3.PublicationDate+ "/n");
            Console.ReadLine();

        }
    }
}
