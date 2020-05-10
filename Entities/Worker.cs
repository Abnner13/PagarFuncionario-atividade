using System.Collections.Generic;
using CSharpMedium.Entities.Enums;

namespace CSharpMedium.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker(string name, WorkerLevel level, double salario, Department departamento)
        {
            Name = name;
            Level = level;
            BaseSalary = salario;
            Department = departamento;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);

        }
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts){
                if(contract.Date.Year == year && contract.Date.Month == month){
                   sum += contract.totalValue();
                }
            }
            return sum;
        }

        public override string ToString()
        {
            return "Name" + "; " + Name
                    + "Department: " + ": " + Level
                    + "Income for " + BaseSalary;
        }
    }
}
