using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace capaDato
{
    public class DatoUniversidad
    {
        NorthwindEntities modeldb = new NorthwindEntities();

        public bool Guardar(employee1 dat)
        {
            modeldb.employee1.Add(dat);
            modeldb.SaveChanges();
            return true;

        }

        public List<employee1> MostrarDatos()
        {
            var query = (from e in modeldb.employee1
                         select e);

            return query.ToList();

        }

    }
}
