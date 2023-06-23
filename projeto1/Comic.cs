using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    public class Comic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Comic(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
