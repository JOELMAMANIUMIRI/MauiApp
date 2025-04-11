namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //Pegar o nome que a pessoa digitou
            string nome = NomeEntry.Text;
            //NomeLabel.Text = "Oi, + nome;
            NomeLabel.Text = $"oi, {nome}";
        }


            // Armazenar o nome em uma variavel
            //Exibir o nome que esta na variavel em uma caixa de texto

        private void OiButton_Clicked(object sender,EventArgs e)
        {
            string nome = NomeEntry.Text;
            //NomeLabel.Text = "Oi, + nome;
            NomeLabel.Text = $"oi, {nome}";

        }
    }

}
