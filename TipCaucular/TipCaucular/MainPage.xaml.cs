namespace TipCaucular
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void Percentage15_Clicked(object sender, EventArgs e)
        {
            TipPercentage.Value = 15;
        }

        private void Percentage30_Clicked(object sender, EventArgs e)
        {
            TipPercentage.Value = 30;
        }

        private void PercentageRoundDown_Clicked(object sender, EventArgs e)
        {
            double gorgeta = TipPercentage.Value;
        }

        private void PercentageRoundUp_Clicked(object sender, EventArgs e)
        {

        }

        private void OnTipPercentage_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valorDoSlider = TipPercentage.Value;
            TipPercentage.Text = valorDoSlider.ToString("2");
        }
    }

}
