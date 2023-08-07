using System;
using System.Collections.Generic;

namespace StudentAPI.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public int? Marks { get; set; }

    public DateTime? Dob { get; set; }
}
