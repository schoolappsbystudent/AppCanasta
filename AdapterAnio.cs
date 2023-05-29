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
   
    class AdapterAnio : BaseAdapter
    {
        Activity context;
        List<Anio> lista;

        public AdapterAnio(Activity context, List<Anio> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View vista = convertView;

            if (vista == null)
                vista = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

            vista.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre.ToString();

            return vista;
        }

    }//fin class

}//fin namespace