using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class AdminDetail
    {
        public int UserId { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }
    }
}
