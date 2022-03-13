// See https://aka.ms/new-console-template for more information
namespace solidConsoleDemo.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            PostDatabase db =new PostDatabase();

            List<string> newPosts =new List<string>();
            newPosts.Add("original Post");
            newPosts.Add("#Tag Post");
            newPosts.Add("@Mention Post");
            newPosts.Add("http//Link Post");


            Post postobject;

            foreach(var post in newPosts)
            {
                if (post.StartsWith("#"))
                {
                    postobject=new TagPost();
                }
                else if (post.StartsWith("@"))
                {
                    postobject=new MentionPost();
                }
                else if (post.StartsWith("http"))
                {
                    postobject=new LinkPost();
                }
                else{
                    postobject=new Post();
                    
                }
                string result =postobject.createPost(db,post);
                Console.WriteLine(result);

            }

        }
    }
}