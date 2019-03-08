using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liebreT
{
    class liebre:corredor //hereda de la clase corredor
    {
        public liebre(int Numero): base(Numero) { }

        new public void correr()
        {
            int avance = base.correr(); //la variable avance la igualamos a la funcion correr

            if (avance <= 4)
            {
                _posicion += 0;
            }
            else if (avance <= 9)
            {
                _posicion += 12;
            }
            else if (avance <= 13)
            {
                _posicion += 5;
            }
            else if (avance <= 16)
            {
                _posicion -= 4;
            }
            else if (avance <= 20)
            {
                _posicion -= 8;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
    
}
