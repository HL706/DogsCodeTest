using System;
using System.Collections.Generic;
using Dogs.Models;
using Xamarin.Forms;

namespace Dogs.Pages
{
    public partial class DogsPage : ContentPage
    {
        DogModel _bindingTest;

        public DogModel BindingTest
        {
            get { return _bindingTest; }
            private set { _bindingTest = value; }
        }

        public DogsPage()
        {
            InitializeComponent();

            BindingTest = new DogModel();
            BindingTest.Name = "Frank";

            BindingContext = BindingTest;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            BindingTest.Name = "Bruno";
        }
    }
}
