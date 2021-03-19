using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            diccionario.Add(1, "Domingo");
            diccionario.Add(2, "Lunes");
            diccionario.Add(3, "Martes");
            diccionario.Add(4, "Miercoles");
            diccionario.Add(5, "Jueves");
            diccionario.Add(6, "Viernes");
            diccionario.Add(7, "Sabado");

            //La propiedad values saca todos los valores de nuestro diccionario 
            foreach(string val in diccionario.Values)
            {
                Console.WriteLine(val);
            }

            //La propiedad ContainsKey nos indica si existe o no una llave dentro de nuestro diccionario
            if (diccionario.ContainsKey(1))
            {
                Console.WriteLine("Existe\n");
            }
            else
            {
                Console.WriteLine("No existe\n");
            }

            //La propiedad ContainsValue nos indica si existe o no un elemento dentro de nuestro diccionario
            if (diccionario.ContainsValue("Domingo"))
            {
                Console.WriteLine("Existe\n");
            }
            else
            {
                Console.WriteLine("No existe\n");
            }

            diccionario.Remove(2); //Esta propiedad elimina un elemento por medio de su key

            Console.WriteLine("El numero de elementos es: " + diccionario.Count +"\n");

            diccionario.Clear(); //Esta prpiedad nos elimina lo que contiene nuestro diccionario

            Console.WriteLine("El numero de elementos es: " + diccionario.Count + "\n");

            Console.ReadLine();
        }
    }
}
