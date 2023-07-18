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
            // Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                if (hospedes.Count<=Suite.Capacidade)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    Console.WriteLine("O número de hóspedes é maior que a capacidade da suíte!");
                }
        }
            
            
        

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            try
            {
                int numeroHospedes = Hospedes.Count;

                return numeroHospedes;
            }
            catch (System.Exception)
            {
                DiasReservados = 0;
                Console.WriteLine("Não foi possível realizar a reserva.");

                return 0;
            }
        }

        public decimal CalcularValorDiaria()
        {
            // Retorna o valor da diária
            // Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

            decimal valor = DiasReservados*Suite.ValorDiaria;

            if (DiasReservados>=10)
            {
                valor -= (valor*10/100);
            }

            return valor;
        }
    }
}