﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHARED.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public  List<BlogPostDto>? topics { get; set; }
    }
}
