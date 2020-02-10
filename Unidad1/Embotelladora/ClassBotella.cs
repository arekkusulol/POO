using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embotelladora
{
    class ClassBotella
    {
        //atributos de clase
        public int nivelLlenado;
            int mililitrosVerificado;

        //metodos de la clase
       public string verificarLlenado()
        {
            string mensaje;
            if (nivelLlenado == 250)
                mensaje = "Llenado perfecto";
            else if (nivelLlenado < 250)
            {
                mililitrosVerificado = 250 - nivelLlenado;
                mensaje = "Le falta " + mililitrosVerificado + "mililitros";
            }
            else
            {
                mililitrosVerificado = nivelLlenado - 250;
                mensaje = "Le sobra " + mililitrosVerificado + "mililitros";
            }

            return mensaje; 
        }
    }
}
