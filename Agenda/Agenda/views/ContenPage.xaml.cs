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
    public partial class ContenPage : ContentPage
    {
        public ContenPage()
        {
            InitializeComponent();
            
            LoadContacts();
        }

        private void LoadContacts()
        {
            var contactclist = new List<Contact>
            {

                new Contact { FullName = "juan perez", Email ="juan.perez@gmail.com", LinkedIn ="juanpa", PhoneNamber ="31648597856", SkypeId ="juan_pa", ImageUrl ="login.png"},
                new Contact { FullName = "pedro perez", Email ="pedro.perez@gmail.com", LinkedIn ="peperez", PhoneNamber ="31648597856", SkypeId ="pe_perez", ImageUrl ="login.png"},
                new Contact { FullName = "felipe perez", Email ="felipe.perez@gmail.com", LinkedIn ="pipe", PhoneNamber ="31648597856", SkypeId ="pipe", ImageUrl ="login.png"},
                new Contact { FullName = "oscar perez", Email ="oscar.perez@gmail.com", LinkedIn ="oscarp", PhoneNamber ="31648597856", SkypeId ="oscar_pe", ImageUrl ="login.png"}

            };

            lsContact.ItemsSource = contactclist;
        }

        private void Contact_selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactselected = (Contact)e.SelectedItem;
            Navigation.PushAsync(new DatailContactPage(contactselected));
        }
    }

   
}