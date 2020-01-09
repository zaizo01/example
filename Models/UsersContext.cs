﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_REST.Models
{
    public class UsersContext: DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options): base(options)
        {

        }
        public DbSet<Users> Usuario { get; set; }
    }
}
