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

namespace App_BD_SQLite.Droid
{
    // Classe para identificar o local do banco de dados no dispositivo
    public class AcessarArquivo
    {
        public static string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, filename);//Retorna o local onde estará o banco de dados
        }
    }
}