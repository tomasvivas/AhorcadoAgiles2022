using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class BaseAhorcado
    {
        private string _nombre;
        private string _palabra;
        private string _letrasIncorrectas;
        private string _letrasCorrectas;
        private int _vidas;
        private string _palabraIngresada;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Palabra { get { return _palabra; } set { _palabra = value; } }
        public string LetrasIncorrectas { get { return _letrasIncorrectas; } set { _letrasIncorrectas = value; } }
        public string LetrasCorrectas { get { return _letrasCorrectas; } set { _letrasCorrectas = value; } }
        public int Vidas { get { return _vidas; } set { _vidas = value; } }
        public string PalabraIngresada { get { return _palabraIngresada; } set { _palabraIngresada = value; } }


        public BaseAhorcado()
        { }
        public BaseAhorcado(string nom, string pal, int vid)
        {
            Nombre = nom;
            Palabra = pal;
            Vidas = vid;
            //PalabraIngresada = "*";
            //for(int i=0; i < (Nombre.Length-1); i++) { PalabraIngresada += "*"; }
        }

        public void SetPalabraIngresada(string pal)
        {
            for (int i = 0; i < (pal.Length); i++) { PalabraIngresada += "*"; }
        }
    }
}
