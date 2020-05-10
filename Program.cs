using System;
using CSharpMedium.Entities;
using CSharpMedium.Entities.Enums;

namespace CSharpMedium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ponha o nome do departamento");
            Department departamento = new Department();
            departamento.name = Console.ReadLine();

            Console.WriteLine("Dados do Trabalhador:");

            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior:");
            string level =  Console.ReadLine();
            WorkerLevel os = Enum.Parse<WorkerLevel>(level);

            Console.Write("Qual a base do Salário?");
            double salary = double.Parse(Console.ReadLine());

            Worker func = new Worker(name, os, salary);

            Console.Write("Quantos contrato(s) para esse funcionário ?");
            int contracts = int.Parse(Console.ReadLine());

           
            for(int i = 0; i < contracts; i++){
                Console.Write("Ponha os Dados do Funcionário #" + i);

                Console.Write("Data :");
                string data = Console.ReadLine();
                DateTime d1 = DateTime.Parse(data);

                Console.Write("Valor po Hora");
                double value = double.Parse(Console.ReadLine());

                Console.Write("Duração");
                int duracao = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(d1, value, duracao);
            }
            

            Console.Write("Entre o Mês e o Ano para calcular o Salario (MM/YYYY):");

            
            Console.Write("Name :");
            Console.WriteLine(func.Name);

            Console.Write("Departamento :");
            Console.WriteLine(departamento.name);
            Console.Write("s :");
        }
    }
}
