using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Models
{
    internal class Students
    {
        [Key]
        public int StudId { get; set; }
        public string? Name { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }

        public float? Height { get; set; }
        public float? Waight  { get; set; }
        
        [ForeignKey ("Grade")]
        public int? GradeId { get; set; }
        public Grade? Grade { get; set; }
    }
}
