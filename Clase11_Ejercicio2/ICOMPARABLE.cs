using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11_Ejercicio2
{
    public class ICOMPARABLE
    {
        public class OrdenarPorNombre: IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                return x.Nombre.CompareTo(y.Nombre);
            }
        }

        public class OrdenarPorEdad : IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                return x.Nombre.CompareTo(y.Nombre);
            }
        }

        public class OrdenarPorSalario : IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                int resultComparer = x.Salario.CompareTo(y.Salario);
                if (resultComparer == 0) return x.Antiguedad.CompareTo(y.Antiguedad);
                return resultComparer;
            }
        }

        public class OrdenarPorSalarioDescendentemente: IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
        {
            int resultComparer = y.Salario.CompareTo(x.Salario);
            if (resultComparer == 0) return y.Antiguedad.CompareTo(x.Antiguedad);
            return resultComparer;
        }
    }

    public class OrdenarPorAntiguedad : IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                return x.Antiguedad.CompareTo(y.Antiguedad);
            }
        }

        public class OrdenarPorPosicion : IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                return x.Posicion.CompareTo(y.Posicion);
            }
        }

    }
}
