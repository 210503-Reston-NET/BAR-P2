using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCModel
{
    public class Category
    {
        public Category() { }
        public Category(string name)
        {
            this.Name = name;
        }

        public Category(int Id, string name) : this(name)
        {
            this.Name = name;
            this.Id = Id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
