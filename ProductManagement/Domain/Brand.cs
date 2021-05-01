using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public Brand() { }
        public Brand(string name) { this.Name = name; }
        public Brand(string name, int id)
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
