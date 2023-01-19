using System;
using System.Collections.Generic;

namespace Blazor_StateManagement.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
    }
}
