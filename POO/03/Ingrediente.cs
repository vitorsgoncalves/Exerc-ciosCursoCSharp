using System;
using System.Collections.Generic;
using System.IO;

namespace Ex3
{


    public class Ingredientes
    {

        private Dictionary<int, string> _listaIngredientes = new Dictionary<int, string>();

        public Ingredientes()
        {
            foreach (string line in System.IO.File.ReadLines("Ingredientes.txt"))
            {
                string[] campos = line.Split(";");
                try
                {
                    _listaIngredientes.Add(int.Parse(campos[0]), line);
                }
                catch (Exception e)
                {
                    Console.WriteLine("erro: {0}", e.Message);
                }
            }
        }

        private static readonly Ingredientes _ingredientes = new Ingredientes();


        public string[] GetIngredientes(int codigo)
        {

            string[] campos = _listaIngredientes[codigo].Split(";");
            return campos;
        }
    }



}