using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Location Location { get; set; }
    }
}
