using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
