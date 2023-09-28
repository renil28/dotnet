using System;
using System.Collections.Generic;

namespace DemoWebApp.Models;

public partial class CourseBookMapping
{
    public int? Id { get; set; }

    public int? CourseId { get; set; }

    public int? BookId { get; set; }
}
