using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookbookie.Models
{
    public class MailModel : Controller
    {
        public string SenderAddress { get; set; }
        public string SenderDisplayName{ get; set; }

        public string Username { get; set; }
        public string PAssword { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string EnableSSL { get; set; }
        public string UseDefaultCredentials { get; set; }
        public string IsBodyHTML { get; set; }
    }
}
