using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookbookie.Models
{
    public class MailModel : Controller
    {
        public string To { get; set; }
        public string From { get; set; }

        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
