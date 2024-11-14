using MauiCadastroEventos.Models;

namespace MauiCadastroEventos
{
    public partial class MainPage : ContentPage
    {
        App PropriedadesApp;

        public MainPage()
        {
            InitializeComponent();

            //Configuracao do Picker para selecionar o local
            PropriedadesApp = (App)Application.Current;
            pck_local.ItemsSource = PropriedadesApp.lista_locais;

            //Configuracao para selecionar data, invalidando datas passadas
            dtpck_inicio.MinimumDate = DateTime.Now;
            dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
            dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(4);
        }

        //Botao para a tela de resumo, e adiciona dados classe
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Evento ev = new Evento
                {
                    EspacoSelecionado = (Local)pck_local.SelectedItem,
                    NomeEvento = nome_evento.Text,
                    QntPessoas = Convert.ToInt32(stp_participantes.Value),
                    CustoPessoas = Convert.ToDouble(custo_participante.Text),
                    DataInicio = dtpck_inicio.Date,
                    DataTermino = dtpck_termino.Date,
                };

                Navigation.PushAsync(new ResumoPage()
                {
                    BindingContext = ev
                });
            }
            catch (Exception ex)
            {
                DisplayAlert("Opa,", ex.Message, "OK");
            }

        }

        //Configuracao para limitar a visualizacao do calendario apartir da data inicio
        private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker agenda = sender as DatePicker;

            DateTime data_inicio = agenda.Date;
            dtpck_termino.MinimumDate = data_inicio.AddDays(1);
            dtpck_termino.MaximumDate = data_inicio.AddMonths(4);
        }
    }

}
