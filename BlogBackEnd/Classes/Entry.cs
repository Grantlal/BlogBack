using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogBackEnd.Classes
{
    public class Entry
    {
        private int Id;
        private string Title;
        private string Body;

        public Entry() { }

        public Entry(int id, string title, string body)
        {
            Id = id;
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
        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return "Id: " + Id + " \nTitle: " + Title + "\nBody: " + Body;
        }
    }
}
