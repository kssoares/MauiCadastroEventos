namespace MauiCadastroEventos.Models
{
    public class Evento
    {
        public Local EspacoSelecionado { get; set; }
        public string NomeEvento { get; set; }
        public int QntPessoas { get; set; }
        public double CustoPessoas { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int Reserva
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }
        public double ValorTotal
        {
            get
            {
                double total = (QntPessoas * CustoPessoas) * Reserva;
                return total;
            }
        }
    }
}
