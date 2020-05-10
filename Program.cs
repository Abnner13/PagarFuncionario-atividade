using System;
using CSharpMedium.Entities;
using CSharpMedium.Entities.Enums;
using System.Globalization;

namespace CSharpMedium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ponha o nome do departamento  : ");
            string depName = Console.ReadLine();
            //Department departamento = new Department();
            //departamento.Name = Console.ReadLine();

            Console.WriteLine("Dados do Trabalhador:");

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Qual a base do Salário ?  ");
            double BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(depName);

            Worker func = new Worker(name, level, BaseSalary, dept);

            Console.Write("Quantos contrato(s) para esse funcionário ?  ");
            int Ncontracts = int.Parse(Console.ReadLine());

           
            for(int i = 0; i < Ncontracts; i++){
                Console.WriteLine($"Ponha os Dados do contrato #{i+1}");

                Console.Write("Data : ");
                DateTime data = DateTime.Parse(Console.ReadLine()); 

                Console.Write("Valor por hora  ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração  ");
                int duracao = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(data, valuePerHour, duracao);
                func.addContract(contrato);
            }
            

            Console.Write("Entre o Mês e o Ano para calcular o Salario (MM/YYYY): ");
            string mesano = Console.ReadLine();
            int Mes = int.Parse(mesano.Substring(0, 2));
            int Ano = int.Parse(mesano.Substring(3));

            double TotalSalary = func.Income(Ano, Mes);
            
            
            Console.Write("Name : ");
            Console.WriteLine(func.Name);

            Console.Write("Departamento : ");
            Console.WriteLine(func.Department.Name);

            Console.Write($"Salario desse Mês {mesano} : ");
            Console.WriteLine(TotalSalary);
        }
    }
}
