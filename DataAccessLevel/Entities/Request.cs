using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLevel.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Question { get; set; }
        public string Contact { get; set; }
    }
}
