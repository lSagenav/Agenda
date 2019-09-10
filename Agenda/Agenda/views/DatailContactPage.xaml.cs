using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatailContactPage : ContentPage
    {
        public DatailContactPage(Contact contact)
        {
            InitializeComponent();
            LoadData(contact);
        }

        private void LoadData(Contact contact)
        {
            Datos.BindingContext = contact;
        }
    }
}