using polyanskiyy15.Models;
using polyanskiyy15.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace polyanskiyy15
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
    

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
