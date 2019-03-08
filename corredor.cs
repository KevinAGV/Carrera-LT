using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liebreT
{
    class corredor
    {
        private int _numero;
        protected int _posicion; //solo acceso a clases que heredan 
        private static Random generador = new Random();

        public corredor(int numero) //es nuestro constructor
        {
            _numero = numero;
            _posicion = 0;
        }

         public int Numero
        {
            get { return _numero; }
        }
        /// <summary>
        /// propiedad para conocer la posicion
        /// </summary>
        public int posicion
        {
            get { return _posicion; }
        }

        public override string ToString()
        {
            //return base.ToString();
            return "El corredor " + _numero.ToString() + " va en la posicion: " + _posicion.ToString();
        }

        public int correr()//nuestro generador de 1 a 20
        {
            return generador.Next(1, 21);
        }
    }
}
