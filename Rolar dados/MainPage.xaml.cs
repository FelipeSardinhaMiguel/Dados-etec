namespace Rolar_dados
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RolarDadoBtn_Clicked(object sender, EventArgs e)
        {
            Random.Next();
        }
    }

}
