using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET___MiniInsta
{
    internal class Posts
    {
        public int Id { get; set; }
        public int IdUser { get; set; }

        public DateTime Date { get; set; }

        public string? Text { get; set; }

        public string ImgPath { get; set; }

        public List<Tags> Tags { get; set; } = new List<Tags>();

        public Users User { get; set; } 

    }
}
