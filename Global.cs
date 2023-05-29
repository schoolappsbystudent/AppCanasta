using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasePractica01
{
   public class Global
    {
        public static List<Anio> anios = new List<Anio>()
        {
            new Anio(1,2005),
            new Anio(2,2006),
            new Anio(3,2007),
            new Anio(4,2008),
             new Anio(5,2009),
             new Anio(6,2010),
             new Anio(7,2011),
             new Anio(8,2012),
             new Anio(9,2013),
             new Anio(10,2014),
             new Anio(11,2015),
             new Anio(12,2016),
             new Anio(13,2017),
             new Anio(14,2018),
             new Anio(15,2019),
        };

        public static List<Mes> Meses = new List<Mes>()
        {
            //meses correspondiente al año 2005:
            new Mes(1,1,"Enero"),
            new Mes(2,1,"Febreo"),
            new Mes(3,1,"Marzo"),
            new Mes(4,1,"Abril"),
            new Mes(5,1,"Mayo"),
            new Mes(6,1,"Junio"),
            new Mes(7,1,"Julio"),
            new Mes(8,1,"Agosto"),
            new Mes(9,1,"Septiembre"),
            new Mes(10,1,"Octubre"),
            new Mes(11,1,"Noviembre"),
            new Mes(12,1,"Diciembre"),

        };

        public static List<Producto> Productos = new List<Producto>()
        {
            //productos correspondientes a los meses del 2005
            new Producto(1,1,1,float.Parse("1504.1"),float.Parse("916.9"),float.Parse("142.8")),
            new Producto(2,1,2,float.Parse("1508.8"),float.Parse("913"),float.Parse("143.8")),
             new Producto(3,1,3,float.Parse("1514.5"),float.Parse("919.3"),float.Parse("144.3")),
              new Producto(4,1,4,float.Parse("1556.3"),float.Parse("1003.9"),float.Parse("146.2")),
              new Producto(5,1,5,float.Parse("1592.6"),float.Parse("927.1"),float.Parse("146.6")),
              new Producto(6,1,6,float.Parse("1597"),float.Parse("925.4"),float.Parse("147.1")),
              new Producto(7,1,7,float.Parse("1611.1"),float.Parse("931.8"),float.Parse("147.9")),
              new Producto(8,1,8,float.Parse("1605.2"),float.Parse("946"),float.Parse("148.2")),
              new Producto(9,1,9,float.Parse("1608.7"),float.Parse("952"),float.Parse("148.7")),
              new Producto(10,1,10,float.Parse("1631.2"),float.Parse("969.2"),float.Parse("149.2")),
              new Producto(11,1,11,float.Parse("1680.8"),float.Parse("968.1"),float.Parse("149.3")),
              new Producto(12,1,12,float.Parse("1679.3"),float.Parse("964.1"),float.Parse("151.4")),



        };


    }//fin class


    public class Anio
    {
        int idanio;
        int nombre;

   

        public Anio(int _idanio,int _nombre)
        {
            this.idanio = _idanio;
            this.nombre = _nombre;

        }

        public int Idanio { get => idanio; set => idanio = value; }
        public int Nombre { get => nombre; set => nombre = value; }

    }

    public class Mes
    {
        int idmes;
        int idanio;
        string nombre;

        public Mes(int idmes, int idanio, string nombre)
        {
            this.Idmes = idmes;
            this.Idanio = idanio;
            this.Nombre = nombre;
        }

        public int Idmes { get => idmes; set => idmes = value; }
        public int Idanio { get => idanio; set => idanio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }

    public class Producto
    {
        int idproducto;
        int idmes;
        int idanio;
        float alimento;
        float hogar;
        float vestuario;

        public Producto(int idproducto,int idanio, int idmes, float alimento, float hogar, float vestuario)
        {
            this.Idproducto = idproducto;
            this.Idmes = idmes;
            this.Alimento = alimento;
            this.Idanio = idanio;
            this.Hogar = hogar;
            
            this.Vestuario = vestuario;
        }

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public int Idmes { get => idmes; set => idmes = value; }
        public float Alimento { get => alimento; set => alimento = value; }
        public float Hogar { get => hogar; set => hogar = value; }
        public float Vestuario { get => vestuario; set => vestuario = value; }
        public int Idanio { get => idanio; set => idanio = value; }
    }


}//fin namespace