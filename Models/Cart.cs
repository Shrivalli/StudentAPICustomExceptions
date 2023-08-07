using System;
using System.Collections.Generic;

namespace StudentAPI.Models;

public partial class Cart
{
    public int Cartid { get; set; }

    public int? Prid { get; set; }

    public int? Noofitems { get; set; }

    public DateTime? Dateoforder { get; set; }

    public int? Eid { get; set; }

    public virtual Employee? EidNavigation { get; set; }

    public virtual Product? Pr { get; set; }
}
