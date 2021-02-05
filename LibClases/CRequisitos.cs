using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CRequisitos : CEntidad
    { //=============== ATRIBUTOS =======================
      //-- Todos heredados de CEntidad ----
      //================ METODOS ========================
      //-------------- Constructores --------------------
        public CRequisitos() : base ("TRequisitos")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "codRequisito", "descripcion" };
        }
        //------ Métodos especificos de Ejemplares ----------------
        /*
        public DataTable ListaEjemplaresDeLibro(string pCodLibro)
        { //-- lista los ejemplares que le corresponden a un libro determinado
            string Consulta = "select * from TRequisitos where codRequisito= '"

            + pCodLibro + "'";

            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }*/
    }
}
