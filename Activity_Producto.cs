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
    [Activity(Label = "Activity_Producto")]
    public class Activity_Producto : Activity
    {
        Mes m;
        Producto p;

        TextView valuefoods;
        TextView valueclothess;
        TextView valuehomes;
        TextView titulo;
        TextView total;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout_Producto); 
            int id = Intent.GetIntExtra("id", 0);

            m= Global.Meses.Where(x => x.Idmes == id).FirstOrDefault();

            p =Global.Productos.Where(x => x.Idmes == m.Idmes).FirstOrDefault();

            titulo = FindViewById<TextView>(Resource.Id.textView_titulomes);
            titulo.Text = m.Nombre;

            valuefoods = FindViewById<TextView>(Resource.Id.textViewvaluefood);
            valuehomes = FindViewById<TextView>(Resource.Id.valuehome);
            valueclothess = FindViewById<TextView>(Resource.Id.valueclothes);
            total= FindViewById<TextView>(Resource.Id.total);

            valuefoods.Text = p.Alimento.ToString();
            valuehomes.Text = p.Vestuario.ToString();
            valueclothess.Text = p.Hogar.ToString();


            total.Text ="Total: "+(p.Alimento+ p.Vestuario+ p.Hogar).ToString();

            //      alimentos.Text = "Alimentos: " + p.Alimento.ToStrin();
            //      vestuario.Text = "Vestuario: " + p.Vestuario.ToString();
            //      hogar.Text = "Usos del hogar " + p.Hogar.ToString();





        }

    }//fin class

}//fin namespace