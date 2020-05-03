using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProb
{
    class OperationsDNE
    {
        //Metodo de la formula del DNE
        public double DNE(double x, double u, double o)
        {
            double resultado=0;

            resultado=(x - u) / o;

            return resultado;
        }

        //Metodo para buscar resultado en la tabla ( BuscarEnTabla() )

    }
    
}
