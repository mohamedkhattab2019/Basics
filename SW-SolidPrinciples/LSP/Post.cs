namespace solidConsoleDemo.LSP
{
    public class Post
    {
        public virtual string createPost(PostDatabase db,string post)
        {
            return db.Add(post);
        }
    }

    public class TagPost : Post{
        // ------public  string createTagPost(PostDatabase db,string post) ----
        //that does not achieve liscove 
        // virtual and over ride the parent methode will apply it 
        //and make the parent replacable 

        // -----soln ----
        // use overide and the same iherted methode
        public override string   createPost(PostDatabase db,string post) 
        
        {
            return db.AddTagPost(post);
            
        }
    }

    
    public class MentionPost : Post{
        // public  string createMentionPost(PostDatabase db,string post)
           // -----soln ----
        // use overide and the same iherted methode
        // with out change in the programe code it will return the answer achieve liskove SP
        public override string   createPost(PostDatabase db,string post) 

        {
            return db.AddMentionPost(post);
            
        }
    }
//--------- we can also add another class 
    public class LinkPost :Post
    {
        public override string   createPost(PostDatabase db,string post) 

        {
            return db.AddLinkPost(post);
            
        }
    }

}