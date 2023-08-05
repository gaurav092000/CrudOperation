﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudOperation.Models
{
    public class CrudContext : DbContext
    {
        public DbSet<Category> categories { get; set; }

        public DbSet<Products> products { get; set; }
    }

}