using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public int ParentCode { get; set; }
        public int ProductBarCode { get; set; }
        public string Description { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public string ImagePath { get; set; }

    }
}
