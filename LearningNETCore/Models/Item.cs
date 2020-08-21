using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LearningNETCore.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(10, ErrorMessage = "You fucked up")]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Due { get; set; }
    }
}
