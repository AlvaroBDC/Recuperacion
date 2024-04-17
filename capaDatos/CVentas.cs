using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CVentas
    {
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public int RutaID { get; set; }
        public int CantidadPersonas { get; set; }
        public decimal ImportePago { get; set; }

        public override string ToString()
        {
            return string.Format("Ventas (VentaID={0}, ClienteID={1}, RutaID={2}, CantidadPersonas={3}, ImportePago={4})",
                                 VentaID,ClienteID,RutaID,CantidadPersonas,ImportePago);
        }
    }
}
