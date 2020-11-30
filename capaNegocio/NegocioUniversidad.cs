using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using capaDato;

namespace capaNegocio
{
    public class NegocioUniversidad
    {
        DatoUniversidad metodos = new DatoUniversidad();

        public bool Guardar(EntidadUniversidad dat)
        {
            employee1 tbl = new employee1();

            tbl.id = dat.id;


            tbl.first_name = dat.first_name;




            return metodos.Guardar(tbl);
        }

        public List<employee1> MostrarDatos()
        {
            return metodos.MostrarDatos(); 
        }
    }
}
