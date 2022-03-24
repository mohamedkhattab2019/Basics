namespace DesignPatterns.Snglton
{
    public class Counter {
        public int counter =0;

        

        // aply singlton pattern using constructor protection
        // you can not create an object of this class only insiide it

        // once you run the app an object will be created of this class 
        //--and will be stored on memory and that is not the most efficient soln 
        // private static Counter instance =new Counter(); 
        
        /// ---- use lazy inititalization don't intitiaate an object on memory untill some one call the function 
        // to best memory performance 
        private static Counter instance = null; 
        
        // with out lock every task will create instance on memory and the counter will not be 2 on both write line
        // use lock to lock crating new object 
        private static object lockObj = new object();
        private  Counter() {}

        public static Counter GetInstance()   // public to call it from outside  return instance of the class
        {
            if (instance == null) // double check
            {

                lock(lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Counter();
                    }
                }
            }
            return instance; /// error if you calll an object not static like the function 
        }
        public void AddOne(){
            counter ++;
        }
    }
}