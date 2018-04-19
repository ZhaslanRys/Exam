using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class DriverService
    {
        public void AddDriver(Driver driver)
        {
            using (var context = new MapContext())
            {
                context.Drivers.Add(driver);
                context.SaveChanges();
            }
        }
        public void DeleteDriver(int id)
        {
            using (var context = new MapContext())
            {
                var driver = context.Drivers.FirstOrDefault(d => d.Id == id);
                if (driver != null)
                {
                    context.Drivers.Remove(driver);
                    context.SaveChanges();
                }
            }
        }
    }
}
