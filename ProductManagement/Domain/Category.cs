using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category(string name) { this.Name = name; }
        public Category(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
