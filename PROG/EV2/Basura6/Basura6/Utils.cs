using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basura6
{
    public delegate int ComparatorDelegate<T>(T n1, T n2);
    public class Utils
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }
        public static void Sort<T>(T[] array, ComparatorDelegate<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) < 0)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        //struct Student
        //{
        //    int age;
        //}
        //class Clase
        //{
        //    Student debug;
        //    int age;
        //}
        //nuevos conceptos: struct, heap
        //diferencia entre struct y class: al crear una nuevo objeto de una clase, en la RAM se crea un número de referencia a ESA clase
        //al crear un nuevo objeto de struct, en la RAM se crea un número que alberga los datos.
        //struct no soporta herencias, class sí
        //struct sirve, por ejemplo, a la hora de copiar y enviar de vuelta datos de la GPU.
        //struct se comporta como un int




        //clase inmutable y que no herede de nadie
        //class,-- struct,-- record
        //se comporta como un readonly
        //record Student(string Name, int Age)
        //{
        //    int Curso { get; set; }

        //}
        //Student s = new Student(..., ...);
        //s.Name;


    }
}
