﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Contact_List
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "contacts.db";
        public static ContactRepository database;
        public static ContactRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ContactRepository(DATABASE_NAME);
                }
                return database;
            }
        }




        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
