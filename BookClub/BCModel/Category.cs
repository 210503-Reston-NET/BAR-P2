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
        public Category(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }

        public Category(int Id, string name, List<Book> books) : this(name, books)
        {
            this.Name = name;
            this.Books = books;
            this.Id = Id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        
    }
}
