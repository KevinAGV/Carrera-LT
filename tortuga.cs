using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liebreT
{
    class tortuga : corredor //hereda de la clase corredor
    {
        public tortuga(int Numero) : base(Numero) { }

        new public void correr()
        {
            int avance = base.correr();
            if(avance<=8)
            {
                _posicion += 3;
            }
            else if(avance<=12)
            {
                _posicion += 6;
            }
            else if (avance <= 16)
            {
                 _posicion -= 5;
            }
            else
            {
                 _posicion -= 9;
            }

        }
        public override string ToString()
        {
            return base.ToString();
        }



    }
}
