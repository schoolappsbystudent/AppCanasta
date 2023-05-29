using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;

namespace ClasePractica01
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            lista = FindViewById<ListView>(Resource.Id.listViewanios);

            lista.Adapter = new AdapterAnio(this, Global.anios);//carga los datos on the listview

            lista.ItemClick+= Lista_Click;

        }

        private void Lista_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(Activity_Meses));

            Anio a = Global.anios[e.Position];
            i.PutExtra("id", a.Idanio);
            StartActivity(i);

        }//fin evento

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }//end class

}//end namespace