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
    [Activity(Label = "Activity_Meses")]
    public class Activity_Meses : Activity
    {
        Anio a;
        TextView t;
        ListView list;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout_Meses);
            int id = Intent.GetIntExtra("id", 0);

            a = Global.anios.Where(x =>x.Idanio==id).FirstOrDefault();

            t= FindViewById<TextView>(Resource.Id.textViewtitulo);
            list= FindViewById<ListView>(Resource.Id.listViewmese);

            t.Text = a.Nombre.ToString();

            list.Adapter = new AdapterMeses(this, Global.Meses.Where(x =>x.Idanio == a.Idanio).ToList());

            list.ItemClick+=Lista_Click;
        }

        private void Lista_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Activity_Producto));

            Mes a = Global.Meses[e.Position];

            i.PutExtra("id", a.Idmes);
            StartActivity(i);

        }//fin evento
    }//fin class

}//fin namespace