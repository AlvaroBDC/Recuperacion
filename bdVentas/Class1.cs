using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdVentas
{
    public class dalVenta
    {
        public void insertarVentas(Ventas vVentas)
        {
            using (var bd = new VentasTurismoEntities())
            {
                bd.Ventas.Add(vVentas);
                bd.SaveChanges();
            }
        } 
    }
}
