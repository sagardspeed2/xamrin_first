﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginBtn(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login Successfull", "ok");
            Navigation.PushAsync(new HomePage(username.Text));
        }

        //private void LoginBtn(object sender, EventArgs e)
        //{
        //DisplayAlert("Login", "Login Successfull", "ok");
        //}
    }
}
