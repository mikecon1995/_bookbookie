
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookbookie.Data
{
    public class Books
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Author { get; set; }

        public String Price { get; set; }

        public String ISBN { get; set; }

        public String ISBN13 { get; set; }

        public String Description { get; set; }

        public String Category { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
