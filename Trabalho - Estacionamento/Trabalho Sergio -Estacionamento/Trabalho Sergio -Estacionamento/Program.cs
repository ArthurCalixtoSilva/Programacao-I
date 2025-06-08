using System;

class Estacionamento
{
    public string placa, marca, modelo, tipo;
    public int horaEntrada, minutoEntrada, horaSaida, minutoSaida;

    public Estacionamento()
    {
        horaEntrada = minutoEntrada = horaSaida = minutoSaida = -1;
    }

    public void CadastrarVeiculo(string p, string m, string mod, string t)
    {
        placa = p; marca = m; modelo = mod; tipo = t.ToLower();
    }

    public void EntradaVeiculo(int h, int m)
    {
        horaEntrada = h; minutoEntrada = m;
    }

    public double SaidaVeiculo(int h, int m)
    {
        if (h < horaEntrada || (h == horaEntrada && m < minutoEntrada))
            return -1;

        horaSaida = h; minutoSaida = m;
        int tempoMin = (horaSaida * 60 + minutoSaida) - (horaEntrada * 60 + minutoEntrada);
        int horas = (int)Math.Ceiling(tempoMin / 60.0);
        double valor = 0;
        switch (tipo)
        {
            case "passeio": valor = horas * 3.5; break;
            case "utilitário": valor = horas * 4.5; break;
            case "caminhão": valor = horas * 10; break;
            case "ônibus": valor = horas * 7.5; break;
        }
        horaEntrada = minutoEntrada = horaSaida = minutoSaida = -1;
        return valor;
    }
}

class Program
{
    static void Main()
    {
        Estacionamento[] vagas = new Estacionamento[10];
        for (int i = 0; i < 10; i++) vagas[i] = new Estacionamento();
        int op;
        do
        {
            Console.WriteLine("1-Entrada\n2-Saída\n3-Sair");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                Console.Write("Vaga (0-9): ");
                int v = int.Parse(Console.ReadLine());
                if (v < 0 || v > 9 || vagas[v].horaEntrada >= 0)
                {
                    Console.WriteLine("Vaga ocupada ou inválida.");
                    continue;
                }
                Console.Write("Placa: ");
                string placa = Console.ReadLine();
                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("Tipo (passeio/utilitário/ônibus/caminhão): ");
                string tipo = Console.ReadLine();
                Console.Write("Hora entrada: ");
                int he = int.Parse(Console.ReadLine());
                Console.Write("Minuto entrada: ");
                int me = int.Parse(Console.ReadLine());
                vagas[v].CadastrarVeiculo(placa, marca, modelo, tipo);
                vagas[v].EntradaVeiculo(he, me);
            }
            else if (op == 2)
            {
                Console.Write("Vaga (0-9): ");
                int v = int.Parse(Console.ReadLine());
                if (v < 0 || v > 9 || vagas[v].horaEntrada < 0)
                {
                    Console.WriteLine("Vaga vazia ou inválida.");
                    continue;
                }
                Console.Write("Hora saída: ");
                int hs = int.Parse(Console.ReadLine());
                Console.Write("Minuto saída: ");
                int ms = int.Parse(Console.ReadLine());
                double valor = vagas[v].SaidaVeiculo(hs, ms);
                if (valor >= 0)
                    Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2"));
                else
                    Console.WriteLine("Saída inválida.");
            }
        } while (op != 3);
    }
}