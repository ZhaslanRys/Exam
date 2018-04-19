using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class CargoService
    {
        public void AddCargo(Cargo cargo)
        {
            using (var context = new MapContext())
            {
                context.Cargoes.Add(cargo);
                context.SaveChanges();
            }
        }
        public void DeleteCargo(int id)
        {
            using (var context = new MapContext())
            {
                var cargo = context.Cargoes.FirstOrDefault(c => c.Id == id);
                if(cargo!= null)
                {
                    context.Cargoes.Remove(cargo);
                    context.SaveChanges();
                }
            }
        }
    }
}
