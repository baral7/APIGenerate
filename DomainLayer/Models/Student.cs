using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Student
    {
        
        [Key]
        public int StudentId { get; set; }
        public string Name
        {
            get; set;
        } = null!;
        public string SAddress { get; set; } = null!;
        }
}
