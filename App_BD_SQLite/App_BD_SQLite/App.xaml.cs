using App_BD_SQLite.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_BD_SQLite
{
    public partial class App : Application
    {
        //Declaração de propriedades públicas (globais)
        public static String DbName;
        public static String DbPath;
        public App()
        {
            InitializeComponent();

            MainPage = new PageMenu();
        }
        
        //Método construtor recebendo local e o nome do banco de dados
        public App(string dbPath, string dbName)
        {
            InitializeComponent();
            App.DbName = dbName;
            App.DbPath = dbPath;
            MainPage = new PageMenu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
