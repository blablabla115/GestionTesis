using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class CTramite : CEntidad
    { //=============== ATRIBUTOS =======================
      //-- Todos heredados de CEntidad ----
      //================ METODOS ========================
      //-------------- Constructores --------------------
        public CTramite() : base("TTramites")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodTramite", "Nombre"};
        }
        //------ Métodos especificos de Requisitos Tramites ----------------
        public DataTable ListaTramites(string pCodTramite)
        { //-- lista los ejemplares que le corresponden a un libro determinado
            string Consulta = "select * from TTramites where CodTramite= '"

            + pCodTramite + "'";

            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
