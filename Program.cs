﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IImprimible
{
    void Imprime();
    void Imprime(int n);
}

class Usuario: IComparable, IImprimible

{
    public string nombre, correo;

    public Usuario(string n, string c)
    {
        this.nombre = n;
        this.correo = c;
    }

    public override string  ToString()
{
 	 return String.Format("{0}:{1}",this.nombre, this.correo);
}
    public int CompareTo(object o)
    {
        Usuario usr = (Usuario)o; 
        return this.nombre.CompareTo(((Usuario) o).nombre);
    }



    public void Imprime()
    {
        throw new NotImplementedException();
    }

    public void Imprime(int n)
    {
        throw new NotImplementedException();
    }
}
    class Program
    {   //Se declara e inicializa una lista generica de objetos tipo Usuario
        static private List<Usuario> usuarios = new List<Usuario>();
        static void Main(string[] args)
        {
            // Se agregan usuarios
            usuarios.Add(new Usuario("ana","ana@gmail.com"));
            usuarios.Add(new Usuario("ale","ale@gmail.com"));
            usuarios.Add(new Usuario("zoe","zoe@gmail.com"));
            usuarios.Add(new Usuario("tom","tom@gmail.com"));
            usuarios.Add(new Usuario("liz","liz@gmail.com"));

            Console.WriteLine("Desordenados");

            foreach(Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }

            usuarios.Sort();
            Console.WriteLine("Ordenados");
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }

            Console.ReadKey();
        }
    }

