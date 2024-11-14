using MauiCadastroEventos.Models;

namespace MauiCadastroEventos
{
    public partial class App : Application
    {
        public List<Local> lista_locais = new List<Local>()
        {
            new Local()
            {
                Espaco = "Palácio Catherine"
            },

            new Local()
            {
                Espaco = "Sala Ambar"
            },

            new Local()
            {
                Espaco = "Grande Salão do Trono"
            },

            new Local()
            {
                Espaco = "Salas Douradas"
            }

        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        // Configuração da janela principal
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 650;

            return window;
        }
    }
}
