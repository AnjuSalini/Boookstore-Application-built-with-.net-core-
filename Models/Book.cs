using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boookstore1.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string bookname { get; set; }
        public string author { get; set; }
    }
}
