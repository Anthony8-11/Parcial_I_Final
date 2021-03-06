using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_nueva4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void advNum_Clicked(object sender, EventArgs e)
        {

            var result = string.Format(numBt.Text);


            result = result.Remove(result.Length - 1);
            int result1 = Convert.ToInt32(result);
            result1 -= 4;
            string result2 = Convert.ToString(result1);

            DisplayAlert("Tu número es:", result2, "Aceptar");
           
        }
    }
}