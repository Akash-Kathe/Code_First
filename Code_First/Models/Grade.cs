using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Models
{
    internal class Grade
    {
        [Key]
        public int Id { get; set; }
        public string? Gradename { get; set; }
        


       
        [ForeignKey("GradeId")]
        List<Students> Students { get; set; }

    }
}
