﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudOperation.Models
{
    public class Category
    {
        [Key]
        [DisplayName("Id")]
        public int CategoryId { get; set; }

        [DisplayName("Category Name")]
        public string CategoryName { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Status")]
        [ScaffoldColumn(false)]
        public bool Status { get; set; }



    }
}