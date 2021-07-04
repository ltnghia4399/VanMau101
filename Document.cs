using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanMau101
{
    class Document
    {
        string id;
        string name;
        string content;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }
    }
}
