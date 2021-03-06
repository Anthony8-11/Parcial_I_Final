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
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();

           

        }

        private void advNum_Clicked(object sender, EventArgs e)
        {

            var result = string.Format(edBt.Text);


            int result1 = Convert.ToInt32(result);
            result1 -= 365;
            string result2 = Convert.ToString(result1);
            string result3 = result2.Insert(2, " del mes ");

            DisplayAlert("Tu cumpleaños es el:", result3, "Aceptar");

        }
    }
}