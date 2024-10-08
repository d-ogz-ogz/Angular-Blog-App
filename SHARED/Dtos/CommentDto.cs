﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int UserId { get; set; }
        public DateTime? Date { get; set; }
        public bool isRemoved { get; set; }
        public UserDto? User { get; set; }

    }
}


