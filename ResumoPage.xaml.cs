namespace MauiCadastroEventos
{
    public partial class ResumoPage : ContentPage
    {
        public ResumoPage()
        {
            InitializeComponent();
        }

        //Botao voltar para tela de cadastro
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}