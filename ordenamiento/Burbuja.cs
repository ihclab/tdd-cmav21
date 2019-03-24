using System;
using System.Collections.Generic;
using System.Text;

namespace ordenamiento
{
    public class Burbuja {
        public void ordenar(int[] arr){
            throw new NotImplementedException("Crear los casos de prueba");
        }
    }
}

mkdir ordenamiento.pruebas
cd ordenamiento.pruebas
dotnet new mstest
dotnet add reference + path de ordenamiento
cd ..
dotnet sln add ordenamiento.pruebas
agregar cambios despues
commit "agregar proyecto de pruebas"
renombrar el de test por pruebasOrdenamiento
despues de poner la clase y todo ejecutar comando test