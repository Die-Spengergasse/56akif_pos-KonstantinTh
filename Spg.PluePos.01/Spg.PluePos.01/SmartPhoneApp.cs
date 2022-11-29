using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01
{
    public class SmartPhoneApp : List<Post>
    {
        public string SmartPhoneId { get; set; }

        public new void Add(Post p)
        {
            if (p != null)
            {
                if (!this.Contains(p))
                {
                    base.Add(p);
                    p.SmartPhone = this;
                }
            }
            else
            { throw new ArgumentNullException("Post is NULL!"); }
        }

        public SmartPhoneApp(string id)
        {
            SmartPhoneId = id;
        }

        public string ProcessPosts()
        {
            //StringBuilder s = new StringBuilder();
            string str = String.Empty;
            foreach(Post p in this)
            {
                str = str + p.Html;
            }
            
            return str;
        }

        public int CalcRating()
        {
            int rating = 0;
            foreach (Post p in this)
            {
                rating += p.Rating;
            }
            return rating;
        }

        public Post? this[string title]
        {
            get
            {
                foreach (Post p in this)
                {
                    if (p.Title == title)
                    {
                        return p;
                    }
                }
                return null;
            }
        }

    }
}
