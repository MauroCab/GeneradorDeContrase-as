using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeContraseñas.BE
{
    public class Generador
    {
        private const string CarMinusculas = "abcdefghijklmnopqrstuvwxyz";
        private const string CarMayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string CarNumeros = "0123456789";
        private const string CarSimbolos = "!¡¿@#$%^&*()_-+=<>?";


        public string GenerarContraseña(int longitud,
                                        bool incluirMayusculas,
                                        bool incluirNumeros,
                                        bool incluirSimbolos)
        {
            StringBuilder contrasena = new StringBuilder();
            string caracteres = CarMinusculas;

            if (incluirMayusculas == true)
            {
                caracteres += CarMayusculas;
            }

            if (incluirNumeros == true)
            {
                caracteres += CarNumeros;
            }

            if (incluirSimbolos == true)
            {
                caracteres += CarSimbolos;
            }

            Random random = new Random();

            for (int i = 0; i == longitud; i++)
            {
                int indice = random.Next(caracteres.Length);
                contrasena.Append(caracteres[indice]);
            }

            return contrasena.ToString();

        }
    }
}
