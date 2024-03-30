namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void SliderGorgeta_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Percent_Vaue.Text = $"Porcentagem da Gorgeta: {((float)SliderGorgeta.Value)}%";
            float valor = Convert.ToSingle(quantiaEntry.Text);
            float gorj = (float)(valor * (SliderGorgeta.Value / 100));
            double tGorj = Math.Round(gorj, 2);

            gorjLabel.Text = $"Gorgeta: R${tGorj}";
            Totals.Text = $"Total:  R$ {Math.Round(tGorj + valor, 2)}";
        }


        private void Set_fifteenPercentClicked(object sender, EventArgs e)
        { 
            
            SliderGorgeta.Value = 15;
            double valor = Convert.ToSingle(quantiaEntry.Text);
            double formatValor = Math.Round(valor, 2);
            double gorj = (double)(valor * (SliderGorgeta.Value / 100));
            double tGorj = Math.Round(gorj, 2);

            gorjLabel.Text = $"Gorgeta: R${tGorj}";
            Totals.Text = $"Total:  R$ {Math.Round(tGorj + valor, 2)}";
        }

        private void Set_thirtyPercentClicked(object sender, EventArgs e)
        {
            SliderGorgeta.Value = 30;
            double valor = Convert.ToSingle(quantiaEntry.Text);
            double gorj = (double)(valor * (SliderGorgeta.Value / 100));
            double tGorj = Math.Round(gorj, 2);

            gorjLabel.Text = $"Gorgeta: R${tGorj}";
            Totals.Text = $"Total:  R$ {Math.Round(tGorj + valor, 2)}";

        }

        private void Arrendondar_Btn_Clicked(object sender, EventArgs e)
        {
            double valorAntes = Convert.ToSingle(quantiaEntry.Text);
            double gorj = (double)(valorAntes * (SliderGorgeta.Value / 100));
            double total = Math.Round(gorj + valorAntes, 0);


            if (total > gorj + valorAntes) {
                total--;
            }

            Totals.Text = $"Total arredondado:  R$ {total}";


        }

        private void ArrendondarCima_Btn_Clicked(object sender, EventArgs e)
        {
            double valorAntes = Convert.ToSingle(quantiaEntry.Text);
            double gorj = (double)(valorAntes * (SliderGorgeta.Value / 100));
            double total = Math.Round(gorj + valorAntes, 0);

            if (total < gorj + valorAntes)
            {
                total++;
            }

            Totals.Text = $"Total arredondado:  R$ {total}";


        }

        private void quantiaEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Percent_Vaue.Text = $"Porcentagem da Gorgeta: {((float)SliderGorgeta.Value)}%";
            float valor = Convert.ToSingle(quantiaEntry.Text);
            float gorj = (float)(valor * (SliderGorgeta.Value / 100));
            double tGorj = Math.Round(gorj, 2);

            gorjLabel.Text = $"Gorgeta: R${tGorj}";
            Totals.Text = $"Total:  R$ {Math.Round(tGorj + valor, 2)}";
        }
    }

}
