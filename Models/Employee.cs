using System;
using System.Collections.Generic;

namespace StudentAPI.Models;

public partial class Employee
{
    public int Empid { get; set; }

    public string? Empname { get; set; }

    public double? Salary { get; set; }

    public DateTime? Dob { get; set; }

    public string? Phno { get; set; }

    public int? Did { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Department? DidNavigation { get; set; }
}
