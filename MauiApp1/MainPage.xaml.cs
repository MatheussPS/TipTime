using System.Text.RegularExpressions;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

        }

        private void Atualiazar_Valores(double sliderValue, float insertValue)
        {
            float gorj = (float)(insertValue * (sliderValue / 100));
            double total = insertValue + gorj;

            Percent_Vaue.Text = $"Porcentagem da Gorgeta: {sliderValue}%";
            gorjLabel.Text = $"Gorgeta: R${Math.Round(gorj, 2)}";
            Totals.Text = $"Total:  R$ {Math.Round(total, 2)}";

        }

        private void SliderGorgeta_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            try
            {
                double sliderValue = Math.Round(SliderGorgeta.Value);
                float valor = Convert.ToSingle(quantiaEntry.Text);

                Atualiazar_Valores(sliderValue, valor);
            }
            catch
            {
                Atualiazar_Valores(0, 0);

            }
        }

        private void Set_PercentClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string btnValue = Regex.Replace(btn.Text, "%", "");
            int btnValueConvert = Convert.ToInt32(btnValue);

            SliderGorgeta.Value = btnValueConvert;

            float valor = Convert.ToSingle(quantiaEntry.Text);

            Atualiazar_Valores(btnValueConvert, valor);

        }

        private void Arrendondar_Btn_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double gorj;
            double valor = Convert.ToSingle(quantiaEntry.Text);

            if (btn.Text == "Arredondar para Baixo")
            {
                gorj = Math.Floor((double)(valor * (SliderGorgeta.Value / 100)));
            }
            else
            {
                gorj = Math.Ceiling((double)(valor * (SliderGorgeta.Value / 100)));
            }


            double total = valor + gorj;

            Totals.Text = $"Total arredondado:  R$ {total,2}";


        }


        private void QuantiaEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double sliderValue = Math.Round(SliderGorgeta.Value);
                float valor = Convert.ToSingle(quantiaEntry.Text);

                Atualiazar_Valores(sliderValue, valor);
            }
            catch
            {
                Atualiazar_Valores(0, 0);

            }

        }
    }

}
