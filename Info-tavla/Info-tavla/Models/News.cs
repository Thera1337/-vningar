using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Info_tavla.Models
{
    public class News
    {
        public string copyright { get; set; }
        public Program[] programs { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Pagination
    {
        public int page { get; set; }
        public int size { get; set; }
        public int totalhits { get; set; }
        public int totalpages { get; set; }
        public string nextpage { get; set; }
    }

    public class Program
    {
        public string description { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string programurl { get; set; }
        public string programslug { get; set; }
        public string programimage { get; set; }
        public string programimagetemplate { get; set; }
        public string programimagewide { get; set; }
        public string programimagetemplatewide { get; set; }
        public string socialimage { get; set; }
        public string socialimagetemplate { get; set; }
        public Socialmediaplatform[] socialmediaplatforms { get; set; }
        public Channel channel { get; set; }
        public bool archived { get; set; }
        public bool hasondemand { get; set; }
        public bool haspod { get; set; }
        public string responsibleeditor { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string broadcastinfo { get; set; }
        public Programcategory programcategory { get; set; }
    }

    public class Channel
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Programcategory
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Socialmediaplatform
    {
        public string platform { get; set; }
        public string platformurl { get; set; }
    }

}
