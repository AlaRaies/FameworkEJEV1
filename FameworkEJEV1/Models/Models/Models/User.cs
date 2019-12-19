﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("UsersTable")]
    public class User
    {
        public virtual string UserName { get; set; }
        public virtual long UserId { get; set; }

    }
}
