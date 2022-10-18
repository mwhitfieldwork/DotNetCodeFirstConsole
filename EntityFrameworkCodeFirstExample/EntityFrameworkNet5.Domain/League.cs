using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkNet5.Domain
{
    public class League
    {
        //Start with the tables that have the fewest dependencies (FKs)
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
