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

        public string Name { get; set; }
        
    }
}
