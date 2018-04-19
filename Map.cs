using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Map
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Mark")]
        public int MarkId { get; set; }
        public virtual Marker Mark { get; set; }
    }
}
