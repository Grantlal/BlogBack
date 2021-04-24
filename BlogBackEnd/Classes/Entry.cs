using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogBackEnd.Classes
{
    public class Entry
    {
        private string Title;
        private string Body;

        public Entry() { }

        public Entry(string title, string body)
        {
            Title = title;
            Body = body;
        }

        public string getTitle()
        {
            return Title;
        }

        public void setTitle(string title)
        {
            Title = title;
        }
        public string getBody()
        {
            return Body;
        }

        public void setBody(string body)
        {
            Body = body;
        }



    }
}
