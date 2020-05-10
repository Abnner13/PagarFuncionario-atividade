using CSharpMedium.Entities.Enums;

namespace CSharpMedium.Entities
{
     class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double Salary { get; set; }

        public Worker(string name,WorkerLevel level,double salario)
        {
            Name = name;
            Level = level;
            Salary = salario;   
        }

        public void addContract(HourContract contract){
            

        }

        //public double Income(){}

        public override string ToString(){
            return "Name"+ "; " + Name 
                    + "Department: " + ": " + Level
                    + "Income for " + Salary; 
        }
    }
}
