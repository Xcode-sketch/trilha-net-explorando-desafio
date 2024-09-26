namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            // *IMPLEMENTADO!!!!*
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception();
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // *IMPLEMENTADO!!!!*
            decimal valor = DiasReservados*Suite.ValorDiaria;
            
            // *IMPLEMENTADO!!!!*
            if (DiasReservados >= 10)
            {
                decimal ResultadoCalculo = DiasReservados * Suite.ValorDiaria;
                decimal ValorReduzido = ResultadoCalculo * 0.10m;
                valor =  ResultadoCalculo - ValorReduzido;
            }

            return valor;
        }
    }
}