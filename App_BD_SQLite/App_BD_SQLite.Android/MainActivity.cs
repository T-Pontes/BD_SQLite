using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace App_BD_SQLite.Droid
{
    [Activity(Label = "App_BD_SQLite", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Criação no banco de dados
            string dbName = "dbAula.db3";
            // Retorno do local de armazenamento do banco de dados
            string dbPath = AcessarArquivo.GetLocalFilePath(dbName);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //LoadApplication(new App());
            //Passagem de parâmentros pelo construtor da página do local e nome do banco de dados
            LoadApplication(new App(dbPath,dbName));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}