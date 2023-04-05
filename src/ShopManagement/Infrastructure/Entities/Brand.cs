using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Brand : IEntity<int>
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
