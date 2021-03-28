using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookbookie.Models
{
    public class BookModel
    {
        public int Id { get; set;}

        public String Title { get; set; }

        public String Author { get; set; }

        public String Price { get; set; }
        public String ISBN { get; set; }

        public String ISBN13 { get; set; }

        public String Description { get; set; }

    }
}
