using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET___MiniInsta
{
    internal class Tags
    {
        public int Id { get; set; }
        public string Tag { get; set; }

        public List<Posts> Posts { get; set; } = new List<Posts>();
    }
}
