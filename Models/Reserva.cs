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
            // Implementado: Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido            
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado: Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido               
                throw new Exception("A suíte selecionada não tem capacidade para quantidade de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado: Retorna a quantidade de hóspedes (propriedade Hospedes)            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado: Retorna o valor da diária            
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            int desconto = 0;

            // Implementado a Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%            
            if (DiasReservados >= 10)
            {
                desconto = (int)(valor * 10 / 100);
                valor -= desconto;
            }

            return valor;
        }
    }
}