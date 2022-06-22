using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercici11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            double resultado;
            double valor1, valor2;

            valor1 = double.Parse(num1.Text);
            valor2 = double.Parse(num2.Text);

            resultado = valor1 + valor2;
            await Navigation.PushAsync(new Page2(resultado));
        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            double resultado;
            double valor1, valor2;

            valor1 = double.Parse(num1.Text);
            valor2 = double.Parse(num2.Text);

            resultado = valor1 - valor2;
            await Navigation.PushAsync(new Page2(resultado));
        }

        private async void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            double resultado;
            double valor1, valor2;

            valor1 = double.Parse(num1.Text);
            valor2 = double.Parse(num2.Text);

            resultado = valor1 * valor2;
            await Navigation.PushAsync(new Page2(resultado));
        }

        private async void btnDivision_Clicked(object sender, EventArgs e)
        {
            double resultado;
            double valor1, valor2;

            valor1 = double.Parse(num1.Text);
            valor2 = double.Parse(num2.Text);

            resultado = valor1 / valor2;
            await Navigation.PushAsync(new Page2(resultado));
        }
    }
}
