﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CDocentes : CEntidad
    {
        //=============== ATRIBUTOS =======================
        //-- Todos heredados de CEntidad ----
        //================ METODOS ========================
        //-------------- Constructores --------------------
        public CDocentes() : base("TDocentes")
        {
        }
        //------ Implementación de metodos abstractos -----
        public override string[] NombresAtributos()
        {
            return new string[] { "CodDocente", "Nombre", "ApellidoPaterno", "ApellidoMaterno", "DNI","telefono","Cargo" };
        }
    }
}
