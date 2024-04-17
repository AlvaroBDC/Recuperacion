using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdVentas
{
    public class dalVenta
    {
        public void insertarVentas(CVentas vVentas)
        {
            using (var bd = new VentasTurismoEntities())
            {
                var per = new Ventas();
                per.VentaID = vVentas.VentaID;
                per.ClienteID = vVentas.ClienteID;
                per.RutaID = vVentas.RutaID;
                per.CantidadPersonas = vVentas.CantidadPersonas;
                per.ImportePago = vVentas.ImportePago;
                bd.Ventas.Add(per);
                bd.SaveChanges();
            }
        } 
    }
}
