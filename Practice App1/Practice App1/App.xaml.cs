﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practice_App1.Services;
using Practice_App1.Views;

namespace Practice_App1
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
