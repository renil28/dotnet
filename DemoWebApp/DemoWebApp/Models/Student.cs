using System;
using System.Collections.Generic;

namespace DemoWebApp.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public int? Course { get; set; }
}
