using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkNet5.Domain
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LeaugeId { get; set; } //foreign key of league
        public virtual League  League { get; set; } //foreign key base class so EF knows where to conntect the FK
    }
}
