using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Question { get; set; }
        public string Contact { get; set; }
    }
}