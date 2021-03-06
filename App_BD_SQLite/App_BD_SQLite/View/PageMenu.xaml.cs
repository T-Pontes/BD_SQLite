using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_BD_SQLite.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMenu : MasterDetailPage
    {
        public PageMenu()
        {
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomeDetail)));
        }

        private async void Open_Home(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomeDetail)));
                //Ocultar menu
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ok!", ex.Message, "Ok");
            }
        }

        private async void Open_Cadastrar(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(CadastrarDetail)));
                //Ocultar menu
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ok!", ex.Message, "Ok");
            }
        }

        private async void Open_Listar(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ListarDetail)));
                //Ocultar menu
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ok!", ex.Message, "Ok");
            }

        }
    }
}