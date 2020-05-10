using System;

namespace CSharpMedium.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

       
        public HourContract(DateTime data, double valuePorhora, int hora)
        {
            Date = data;
            valuePerHour = valuePorhora;
            hours = hora;
        }
        public double totalValue(){
            return valuePerHour * hours;
        }
    }
}
