using Android.Content;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact_List
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contact_info : ContentPage
    {
        public Contact_info()
        {
            InitializeComponent();
        }

        void Call(object sender, EventArgs e)
        {

            Device.OpenUri(new Uri("tel:" + PhoneNumber.Text));
        }

        private void DeleteContact(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            App.Database.DeleteItem(contact.Id);
            MainPage mainPage = new MainPage();
            this.Navigation.PushAsync(mainPage);
        }

        private void Cancel(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Navigation.PushAsync(mainPage);
        }

        private async void ChangeContact(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext; 
            ContactPage contactPage = new ContactPage();
            contactPage.BindingContext = contact;
            await Navigation.PushAsync(contactPage);
        }
    }
}