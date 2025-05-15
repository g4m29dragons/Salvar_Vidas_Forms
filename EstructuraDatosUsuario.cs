using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPS_Salvar_Vidas
{
    internal class EstructuraDatosUsuario
    {
        public string TipoIdentificacion { get; set; }
        public int NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Estrato { get; set; }
        public string TipoAtencion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal ValorCopago { get; set; }
    }
}
