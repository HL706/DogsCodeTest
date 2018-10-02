using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Dogs.Pages
{
    public partial class DogsPage : ContentPage
    {
        int _count = 0;

        public DogsPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            button.Text = $"You clicked {++_count} times!";
        }
    }
}
