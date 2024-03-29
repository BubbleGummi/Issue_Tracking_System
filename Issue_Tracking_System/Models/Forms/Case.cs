﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue_Tracking_System.Models.Forms
{
    internal class Case
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CustomerId { get; set; }
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;

        public string? Email { get; set; } = null!;
        public string Status { get; set; } = "Not started";
    }
}

