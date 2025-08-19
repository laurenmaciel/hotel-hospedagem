using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Luiza");
Pessoa p2 = new Pessoa(nome: "Rodolfo");
//Pessoa p3 = new Pessoa(nome: "Rosa", "Holloway");

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Luxo", capacidade: 2, valorDiaria: 195);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine("╔════════════════════════════════════════╗");
Console.WriteLine($"║Hóspedes: {reserva.ObterQuantidadeHospedes(),-30}║");
Console.WriteLine($"║Valor diária: {reserva.CalcularValorDiaria(),-26:F2}║");
Console.WriteLine("╠════════════════════════════════════════╣");
Console.WriteLine($"║Suíte {reserva.Suite.TipoSuite,-34}║");
foreach (var hospede in reserva.Hospedes)
{
    Console.WriteLine($"║ • {hospede.NomeCompleto, -37}║");
}
Console.WriteLine("╚════════════════════════════════════════╝");