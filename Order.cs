using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("FromCompany")]
        public int FromTheCompanyId { get; set; }
        [ForeignKey("ToCompany")]
        public int ToTheCompanyId { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }
        [ForeignKey("Cargo")]
        public int CargoId { get; set; }
        public double MasCargo { get; set; }
        public int Price { get; set; }
        public Company ToCompany { get; set; }
        public Company FromCompany { get; set; }
        public Car Car { get; set; }
        public Cargo Cargo { get; set; }
    }
}
