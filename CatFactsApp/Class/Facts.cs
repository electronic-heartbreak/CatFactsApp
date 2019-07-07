using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactsApp.Class
{

    public class Facts
    {
        public All[] all { get; set; }
    }

    public class All
    {
        public string _id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public User user { get; set; }
        public int upvotes { get; set; }
        public object userUpvoted { get; set; }
    }

    public class User
    {
        public string _id { get; set; }
        public Name name { get; set; }
    }

    public class Name
    {
        public string first { get; set; }
        public string last { get; set; }
    }

}
