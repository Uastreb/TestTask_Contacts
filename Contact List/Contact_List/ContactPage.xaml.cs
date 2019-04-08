using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contact_List
{
	public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

      
        private async void SaveContact(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            if (!String.IsNullOrEmpty(contact.Name))
            {
                App.Database.SaveItem(contact);
            }

            Contact_info contact_info = new Contact_info();
            contact_info.BindingContext = contact;
            await Navigation.PushAsync(contact_info);
        }
        
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}