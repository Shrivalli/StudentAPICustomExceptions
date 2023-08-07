using System;
using System.Collections.Generic;

namespace StudentAPI.Models;

public partial class Product
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public int? Price { get; set; }

    public int? Qty { get; set; }

    public DateTime? Dom { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
