using System;
using System.IO;
using System.Collections;

namespace bronzetti.christian._4h.arraylist
{
    class Program
    {
       private static void RiordinaArraylist(ArrayList a)
       {
            for (int i = 0; i < a.Count - 1; i++)
            {

                int min = i;
                for (int j = i + 1; j < a.Count; j++)
                    if (a[j].ToString().CompareTo(a[min]) < 0)
                        min = j;

                string tmp = (string)a[min];
                a[min] = a[i];
                a[i] = tmp;
            }
       }
        static void Main(string[] args)
        {
            Console.WriteLine("Programma che dimostra il funzionamento di una arraylist, scritto da C. Bronzetti 4H");
            //legge lettere dell'alfabeto da file e le mette nella lista e poi le sorta dalla A alla Z

            ArrayList alfabeto = new ArrayList();

            StreamReader sr = new StreamReader(@"Alfabeto.dat");
            
            //lettura file
            while(!sr.EndOfStream)
                alfabeto.Add(sr.ReadLine());

            Console.WriteLine("Stampa in ordine casuale");
            //stampare utilizzando for
            //for (int i = 0; i < alfabeto.Count; i++)
            //    Console.Write($"{alfabeto[i]} ");
            
            //stampa utilizzando for each 
            //esempio 1 con tipo var 
            foreach (var a in alfabeto)
                Console.Write($"{a} ");

            //selection sort
            RiordinaArraylist(alfabeto);

            Console.WriteLine("\nStampa in ordine alfabetico");

            //esempio 2 con tipo object
            foreach (object a in alfabeto)
                Console.Write($"{a} ");
        }
    }
}
