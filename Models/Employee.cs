﻿using System;
using System.Collections.Generic;

namespace DDGshop_DoAn1.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? UserId { get; set; }

    public virtual UserAccount? User { get; set; }
}
