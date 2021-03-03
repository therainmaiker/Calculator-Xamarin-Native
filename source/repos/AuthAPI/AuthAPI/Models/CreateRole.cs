﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Models
{
    public class CreateRole
    {
        [Required] public int RoleID { get; set; }

        [Required] public string RoleName { get; set; }
    }
}
