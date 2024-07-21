using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET___MiniInsta
{
    internal class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pswd { get; set; }

        public bool IsOpen { get; set; } = true;

        public bool Gender { get; set; }

        public DateTime? Birthday { get; set; }

        public List<Posts> Posts { get; set; } = new List<Posts>();

    }
}
